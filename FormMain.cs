using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ISPVDemoKlient.IkpWebService;

namespace ISPVDemoKlient
{
  public partial class FormMain : Form
  {
    private string xmlFileName { get; set; }
    private IspvChyby ispvChyby;

    private string XmlFileName
    {
      get => xmlFileName;
      set { xmlFileName = value; labelXmlFile.Text = value; }
    }
    public FormMain()
    {
      InitializeComponent();
      overitStavIkp();
    }

    private IkpWebServiceSoapClient getIkpWebServiceClient()
    {
      return new IkpWebServiceSoapClient();
    }

    private void Zprava( string zprava )
    {
      textBox.AppendText( DateTime.Now.ToLongTimeString() );
      textBox.AppendText( Environment.NewLine );
      textBox.AppendText( zprava );
      textBox.AppendText( Environment.NewLine );
      textBox.AppendText( Environment.NewLine );
      tabControl.TabIndex = 0;
    }
    private void Zprava( Exception exc )
    {
      this.Zprava( exc.Message );
    }

    private void btDostupnost_Click( object sender, EventArgs e )
    {
      overitStavIkp();
    }

    private void btSelectXmlFile_Click( object sender, EventArgs e )
    {
      if ( openFileDialog.ShowDialog() == DialogResult.OK )
      {
        XmlFileName = openFileDialog.FileName;
      }
    }
    private void btKontroly_Click( object sender, EventArgs e )
    {
      zkontrolovatData();
    }
    private void btOdeslatData_Click( object sender, EventArgs e )
    {
      odeslatData();
    }
    private void overitStavIkp()
    {
      try
      {
        IkpWebServiceSoapClient ikpWebService = getIkpWebServiceClient();

        StavApi stavApi = ikpWebService.OveritStavApi();

        Zprava( stavApi.Zprava );
        Zprava( $"Adresa služby: {ikpWebService.Endpoint.ListenUri.AbsoluteUri}" );
      }
      catch ( Exception exc )
      {
        Zprava( exc );
      }
    }



    private void zkontrolovatData()
    {
      try
      {
        IkpWebServiceSoapClient ikpWebService = getIkpWebServiceClient();

        byte[] data = File.ReadAllBytes( xmlFileName );

        ispvChyby = ikpWebService.ZkontrolovatData( data );

        var zavazneChybyId = ispvChyby.CiselnikChyb.Where( ch => ch.Uroven == Uroven.Z ).Select(ch=>ch.IdChyba).ToList();
        var varovaniId = ispvChyby.CiselnikChyb.Where( ch => ch.Uroven == Uroven.V ).Select( ch => ch.IdChyba ).ToList();

        var zavaznychChybMi = ispvChyby.ChybyEkonomickehoSubjektu.Where( idch => zavazneChybyId.Contains( idch ) ).Count();
        var varovaniMi = ispvChyby.ChybyEkonomickehoSubjektu.Where( idch => varovaniId.Contains( idch ) ).Count();

        var vsechnyChybyMp = ispvChyby.ChybyPracovnichPomeru.SelectMany( p => p.IdChyby ).ToList();
        var zavaznychChybMp = vsechnyChybyMp.Where( idch => zavazneChybyId.Contains( idch ) ).Count();
        var varovaniMp = vsechnyChybyMp.Where( idch => varovaniId.Contains( idch ) ).Count();

        var zprava = new StringBuilder();

        zprava.AppendLine( "Data byla zkontrolována." );
        zprava.AppendLine( $"Počet záznamů v údajích o pracovních poměrech (MP):{ispvChyby.ChybyPracovnichPomeru.Count()}" );

        zprava.AppendLine( $"Počet závažných chyb v údajích o ekonomickém subjektu (MI):{zavaznychChybMi}" );
        zprava.AppendLine( $"Počet varování v údajích o ekonomickém subjektu (MI):{varovaniMi}" );

        zprava.AppendLine( $"Počet chyb v údajích o pracovních poměrech (MP):{zavaznychChybMp}" );
        zprava.AppendLine( $"Počet varování v údajích o pracovních poměrech (MP):{varovaniMp}" );

        if ( ispvChyby.ChybyEkonomickehoSubjektu.Any() && ispvChyby.ChybyPracovnichPomeru.Any() )
        {
          zprava.AppendLine( "Podrobnosti najdete na dalších záložkách" );
        }
        Zprava( zprava.ToString() );

        dataGridViewChybyEkSubjektu.DataSource = ispvChyby.CiselnikChyb.Where( ch => ispvChyby.ChybyEkonomickehoSubjektu.Contains( ch.IdChyba ) )
          .Select( ch => new { ch.IdChyba, ch.Nazev, ch.Popis, ch.Uroven, Polozky = string.Join( ",", ch.Polozky ) } )
          .OrderBy( ch => ch.Nazev )
          .ToList();

        dataGridViewPracovniPomery.DataSource = ispvChyby.ChybyPracovnichPomeru.OrderBy( x => x.IDZAM ).ToList();
        if ( dataGridViewPracovniPomery.Rows.Count > 0 )
        {
          dataGridViewPracovniPomery.CurrentCell = dataGridViewPracovniPomery.Rows[0].Cells[0];
          dataGridViewPracovniPomery_RowEnter( null, null );
        }

      }
      catch ( Exception exc )
      {
        Zprava( exc );
      }
    }


    private void odeslatData()
    {
      try
      {
        IkpWebServiceSoapClient ikpWebService = getIkpWebServiceClient();

        byte[] data = File.ReadAllBytes( xmlFileName );

        ikpWebService.OdeslatData( data, textBoxJmeno.Text, textBoxEmail.Text, textBoxTelefon.Text, textBoxZprava.Text );

        Zprava( "Data úspešně odeslána." );
      }
      catch ( Exception exc )
      {
        Zprava( exc );
      }
    }

    private void dataGridViewPracovniPomery_RowEnter( object sender, DataGridViewCellEventArgs e )
    {
      if ( dataGridViewPracovniPomery.CurrentRow != null )
      {
        string idzam = (string) dataGridViewPracovniPomery.CurrentRow.Cells[0].Value;

        ArrayOfInt idChybyPracovnihoPomeru = ispvChyby.ChybyPracovnichPomeru
          .Single( z => z.IDZAM == idzam )
          .IdChyby;

        var chybyPracovnihoPomeru = ispvChyby.CiselnikChyb.Where( ch => idChybyPracovnihoPomeru.Contains( ch.IdChyba ) )
          .Select( ch => new { ch.IdChyba, ch.Nazev, ch.Popis, ch.Uroven, Polozky = string.Join( ",", ch.Polozky ) } )
          .OrderBy( ch => ch.Nazev )
          .ToList();

        dataGridViewChybyPracovnihoPomeru.DataSource = chybyPracovnihoPomeru;
      }
    }
  }
}
