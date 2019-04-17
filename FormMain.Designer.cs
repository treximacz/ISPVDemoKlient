namespace ISPVDemoKlient
{
  partial class FormMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if ( disposing && (components != null) )
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btDostupnost = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.lblXmlFileName = new System.Windows.Forms.Label();
      this.labelXmlFile = new System.Windows.Forms.Label();
      this.btSelectXmlFile = new System.Windows.Forms.Button();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.tabPageLog = new System.Windows.Forms.TabPage();
      this.textBox = new System.Windows.Forms.RichTextBox();
      this.tabChybyMi = new System.Windows.Forms.TabPage();
      this.dataGridViewChybyEkSubjektu = new System.Windows.Forms.DataGridView();
      this.tabChybyMp = new System.Windows.Forms.TabPage();
      this.splitContainerChybyMp = new System.Windows.Forms.SplitContainer();
      this.dataGridViewPracovniPomery = new System.Windows.Forms.DataGridView();
      this.dataGridViewChybyPracovnihoPomeru = new System.Windows.Forms.DataGridView();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
      this.btKontroly = new System.Windows.Forms.Button();
      this.btOdeslatData = new System.Windows.Forms.Button();
      this.lblJmeno = new System.Windows.Forms.Label();
      this.lblEmail = new System.Windows.Forms.Label();
      this.lblTelefon = new System.Windows.Forms.Label();
      this.lblZprava = new System.Windows.Forms.Label();
      this.textBoxJmeno = new System.Windows.Forms.TextBox();
      this.textBoxEmail = new System.Windows.Forms.TextBox();
      this.textBoxTelefon = new System.Windows.Forms.TextBox();
      this.textBoxZprava = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.panel1.SuspendLayout();
      this.tabControl.SuspendLayout();
      this.tabPageLog.SuspendLayout();
      this.tabChybyMi.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChybyEkSubjektu)).BeginInit();
      this.tabChybyMp.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerChybyMp)).BeginInit();
      this.splitContainerChybyMp.Panel1.SuspendLayout();
      this.splitContainerChybyMp.Panel2.SuspendLayout();
      this.splitContainerChybyMp.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPracovniPomery)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChybyPracovnihoPomeru)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btDostupnost
      // 
      this.btDostupnost.Location = new System.Drawing.Point(12, 16);
      this.btDostupnost.Name = "btDostupnost";
      this.btDostupnost.Size = new System.Drawing.Size(129, 23);
      this.btDostupnost.TabIndex = 0;
      this.btDostupnost.Text = "Dostupnost serveru";
      this.btDostupnost.UseVisualStyleBackColor = true;
      this.btDostupnost.Click += new System.EventHandler(this.btDostupnost_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1113, 51);
      this.panel1.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(188, 17);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(402, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Demonstrační příklad využití webových služeb internetového kontrolního programu";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label1.Location = new System.Drawing.Point(11, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(171, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "ISPV Demo klient";
      // 
      // lblXmlFileName
      // 
      this.lblXmlFileName.AutoSize = true;
      this.lblXmlFileName.Location = new System.Drawing.Point(9, 89);
      this.lblXmlFileName.Name = "lblXmlFileName";
      this.lblXmlFileName.Size = new System.Drawing.Size(231, 13);
      this.lblXmlFileName.TabIndex = 3;
      this.lblXmlFileName.Text = "Soubor, který chcete zkontrolovat nebo odeslat";
      // 
      // labelXmlFile
      // 
      this.labelXmlFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.labelXmlFile.Location = new System.Drawing.Point(12, 109);
      this.labelXmlFile.Name = "labelXmlFile";
      this.labelXmlFile.Size = new System.Drawing.Size(198, 18);
      this.labelXmlFile.TabIndex = 2;
      this.labelXmlFile.Text = "--";
      // 
      // btSelectXmlFile
      // 
      this.btSelectXmlFile.Location = new System.Drawing.Point(216, 105);
      this.btSelectXmlFile.Name = "btSelectXmlFile";
      this.btSelectXmlFile.Size = new System.Drawing.Size(44, 23);
      this.btSelectXmlFile.TabIndex = 1;
      this.btSelectXmlFile.Text = "...";
      this.btSelectXmlFile.UseVisualStyleBackColor = true;
      this.btSelectXmlFile.Click += new System.EventHandler(this.btSelectXmlFile_Click);
      // 
      // tabControl
      // 
      this.tabControl.Controls.Add(this.tabPageLog);
      this.tabControl.Controls.Add(this.tabChybyMi);
      this.tabControl.Controls.Add(this.tabChybyMp);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 0);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(738, 597);
      this.tabControl.TabIndex = 2;
      // 
      // tabPageLog
      // 
      this.tabPageLog.Controls.Add(this.textBox);
      this.tabPageLog.Location = new System.Drawing.Point(4, 22);
      this.tabPageLog.Name = "tabPageLog";
      this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageLog.Size = new System.Drawing.Size(730, 571);
      this.tabPageLog.TabIndex = 0;
      this.tabPageLog.Text = "Log";
      this.tabPageLog.UseVisualStyleBackColor = true;
      // 
      // textBox
      // 
      this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.textBox.Location = new System.Drawing.Point(3, 3);
      this.textBox.Name = "textBox";
      this.textBox.ReadOnly = true;
      this.textBox.Size = new System.Drawing.Size(724, 565);
      this.textBox.TabIndex = 0;
      this.textBox.Text = "";
      // 
      // tabChybyMi
      // 
      this.tabChybyMi.Controls.Add(this.dataGridViewChybyEkSubjektu);
      this.tabChybyMi.Location = new System.Drawing.Point(4, 22);
      this.tabChybyMi.Name = "tabChybyMi";
      this.tabChybyMi.Size = new System.Drawing.Size(730, 544);
      this.tabChybyMi.TabIndex = 2;
      this.tabChybyMi.Text = "Chyby ekonomického subjektu (MI)";
      this.tabChybyMi.UseVisualStyleBackColor = true;
      // 
      // dataGridViewChybyEkSubjektu
      // 
      this.dataGridViewChybyEkSubjektu.AllowUserToAddRows = false;
      this.dataGridViewChybyEkSubjektu.AllowUserToDeleteRows = false;
      this.dataGridViewChybyEkSubjektu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewChybyEkSubjektu.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewChybyEkSubjektu.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewChybyEkSubjektu.Name = "dataGridViewChybyEkSubjektu";
      this.dataGridViewChybyEkSubjektu.ReadOnly = true;
      this.dataGridViewChybyEkSubjektu.Size = new System.Drawing.Size(730, 544);
      this.dataGridViewChybyEkSubjektu.TabIndex = 1;
      // 
      // tabChybyMp
      // 
      this.tabChybyMp.Controls.Add(this.splitContainerChybyMp);
      this.tabChybyMp.Location = new System.Drawing.Point(4, 22);
      this.tabChybyMp.Name = "tabChybyMp";
      this.tabChybyMp.Padding = new System.Windows.Forms.Padding(3);
      this.tabChybyMp.Size = new System.Drawing.Size(730, 544);
      this.tabChybyMp.TabIndex = 1;
      this.tabChybyMp.Text = "Chyby pracovních poměrů (MP)";
      this.tabChybyMp.UseVisualStyleBackColor = true;
      // 
      // splitContainerChybyMp
      // 
      this.splitContainerChybyMp.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerChybyMp.Location = new System.Drawing.Point(3, 3);
      this.splitContainerChybyMp.Name = "splitContainerChybyMp";
      this.splitContainerChybyMp.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainerChybyMp.Panel1
      // 
      this.splitContainerChybyMp.Panel1.Controls.Add(this.dataGridViewPracovniPomery);
      // 
      // splitContainerChybyMp.Panel2
      // 
      this.splitContainerChybyMp.Panel2.Controls.Add(this.dataGridViewChybyPracovnihoPomeru);
      this.splitContainerChybyMp.Size = new System.Drawing.Size(724, 538);
      this.splitContainerChybyMp.SplitterDistance = 220;
      this.splitContainerChybyMp.TabIndex = 0;
      // 
      // dataGridViewPracovniPomery
      // 
      this.dataGridViewPracovniPomery.AllowUserToAddRows = false;
      this.dataGridViewPracovniPomery.AllowUserToDeleteRows = false;
      this.dataGridViewPracovniPomery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewPracovniPomery.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewPracovniPomery.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewPracovniPomery.Name = "dataGridViewPracovniPomery";
      this.dataGridViewPracovniPomery.ReadOnly = true;
      this.dataGridViewPracovniPomery.Size = new System.Drawing.Size(724, 220);
      this.dataGridViewPracovniPomery.TabIndex = 0;
      this.dataGridViewPracovniPomery.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPracovniPomery_RowEnter);
      // 
      // dataGridViewChybyPracovnihoPomeru
      // 
      this.dataGridViewChybyPracovnihoPomeru.AllowUserToAddRows = false;
      this.dataGridViewChybyPracovnihoPomeru.AllowUserToDeleteRows = false;
      this.dataGridViewChybyPracovnihoPomeru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewChybyPracovnihoPomeru.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewChybyPracovnihoPomeru.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewChybyPracovnihoPomeru.Name = "dataGridViewChybyPracovnihoPomeru";
      this.dataGridViewChybyPracovnihoPomeru.ReadOnly = true;
      this.dataGridViewChybyPracovnihoPomeru.Size = new System.Drawing.Size(724, 314);
      this.dataGridViewChybyPracovnihoPomeru.TabIndex = 0;
      // 
      // openFileDialog
      // 
      this.openFileDialog.DefaultExt = "XML";
      this.openFileDialog.FileName = "ISPVData.XML";
      this.openFileDialog.Title = "Vyberte XML soubor, který chcete zkontrolovat nebo odeslat";
      // 
      // fileSystemWatcher1
      // 
      this.fileSystemWatcher1.EnableRaisingEvents = true;
      this.fileSystemWatcher1.SynchronizingObject = this;
      // 
      // btKontroly
      // 
      this.btKontroly.Location = new System.Drawing.Point(12, 130);
      this.btKontroly.Name = "btKontroly";
      this.btKontroly.Size = new System.Drawing.Size(129, 23);
      this.btKontroly.TabIndex = 4;
      this.btKontroly.Text = "Zkontrolovat data";
      this.btKontroly.UseVisualStyleBackColor = true;
      this.btKontroly.Click += new System.EventHandler(this.btKontroly_Click);
      // 
      // btOdeslatData
      // 
      this.btOdeslatData.Location = new System.Drawing.Point(9, 465);
      this.btOdeslatData.Name = "btOdeslatData";
      this.btOdeslatData.Size = new System.Drawing.Size(129, 23);
      this.btOdeslatData.TabIndex = 5;
      this.btOdeslatData.Text = "Odeslat data";
      this.btOdeslatData.UseVisualStyleBackColor = true;
      this.btOdeslatData.Click += new System.EventHandler(this.btOdeslatData_Click);
      // 
      // lblJmeno
      // 
      this.lblJmeno.AutoSize = true;
      this.lblJmeno.Location = new System.Drawing.Point(6, 206);
      this.lblJmeno.Name = "lblJmeno";
      this.lblJmeno.Size = new System.Drawing.Size(41, 13);
      this.lblJmeno.TabIndex = 6;
      this.lblJmeno.Text = "Jméno:";
      // 
      // lblEmail
      // 
      this.lblEmail.AutoSize = true;
      this.lblEmail.Location = new System.Drawing.Point(6, 255);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(35, 13);
      this.lblEmail.TabIndex = 7;
      this.lblEmail.Text = "Email:";
      // 
      // lblTelefon
      // 
      this.lblTelefon.AutoSize = true;
      this.lblTelefon.Location = new System.Drawing.Point(6, 310);
      this.lblTelefon.Name = "lblTelefon";
      this.lblTelefon.Size = new System.Drawing.Size(46, 13);
      this.lblTelefon.TabIndex = 8;
      this.lblTelefon.Text = "Telefon:";
      // 
      // lblZprava
      // 
      this.lblZprava.AutoSize = true;
      this.lblZprava.Location = new System.Drawing.Point(6, 365);
      this.lblZprava.Name = "lblZprava";
      this.lblZprava.Size = new System.Drawing.Size(44, 13);
      this.lblZprava.TabIndex = 9;
      this.lblZprava.Text = "Zpráva:";
      // 
      // textBoxJmeno
      // 
      this.textBoxJmeno.Location = new System.Drawing.Point(9, 222);
      this.textBoxJmeno.Name = "textBoxJmeno";
      this.textBoxJmeno.Size = new System.Drawing.Size(198, 20);
      this.textBoxJmeno.TabIndex = 10;
      this.textBoxJmeno.Text = "Josef Testů";
      // 
      // textBoxEmail
      // 
      this.textBoxEmail.Location = new System.Drawing.Point(9, 271);
      this.textBoxEmail.Name = "textBoxEmail";
      this.textBoxEmail.Size = new System.Drawing.Size(198, 20);
      this.textBoxEmail.TabIndex = 11;
      this.textBoxEmail.Text = "test@testfirma.cz";
      // 
      // textBoxTelefon
      // 
      this.textBoxTelefon.Location = new System.Drawing.Point(9, 326);
      this.textBoxTelefon.Name = "textBoxTelefon";
      this.textBoxTelefon.Size = new System.Drawing.Size(198, 20);
      this.textBoxTelefon.TabIndex = 12;
      this.textBoxTelefon.Text = "111 222 333";
      // 
      // textBoxZprava
      // 
      this.textBoxZprava.Location = new System.Drawing.Point(9, 381);
      this.textBoxZprava.Multiline = true;
      this.textBoxZprava.Name = "textBoxZprava";
      this.textBoxZprava.Size = new System.Drawing.Size(198, 78);
      this.textBoxZprava.TabIndex = 13;
      this.textBoxZprava.Text = "Posíláme Vám testovací data za aktuální čtvrtletí.\r\nJosef Testů\r\n";
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(9, 42);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(358, 33);
      this.label4.TabIndex = 14;
      this.label4.Text = "Ověří, jestli je server dostupný, vrací orientační informaci o zatížení serveru";
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(9, 156);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(348, 33);
      this.label5.TabIndex = 15;
      this.label5.Text = "Odešle vybraný XML soubor ke kontrolám. Vrací přehled nalezených chyb";
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(9, 491);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(355, 35);
      this.label6.TabIndex = 16;
      this.label6.Text = "Odešle vybraný XML soubor ke zpracování, v případě úspěšného odeslání nic nevrací" +
    "";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.btDostupnost);
      this.panel2.Controls.Add(this.btKontroly);
      this.panel2.Controls.Add(this.label5);
      this.panel2.Controls.Add(this.btOdeslatData);
      this.panel2.Controls.Add(this.label4);
      this.panel2.Controls.Add(this.lblJmeno);
      this.panel2.Controls.Add(this.btSelectXmlFile);
      this.panel2.Controls.Add(this.lblEmail);
      this.panel2.Controls.Add(this.lblXmlFileName);
      this.panel2.Controls.Add(this.lblTelefon);
      this.panel2.Controls.Add(this.textBoxZprava);
      this.panel2.Controls.Add(this.lblZprava);
      this.panel2.Controls.Add(this.labelXmlFile);
      this.panel2.Controls.Add(this.textBoxJmeno);
      this.panel2.Controls.Add(this.textBoxTelefon);
      this.panel2.Controls.Add(this.textBoxEmail);
      this.panel2.Controls.Add(this.label6);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(371, 597);
      this.panel2.TabIndex = 17;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 51);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.panel2);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tabControl);
      this.splitContainer1.Size = new System.Drawing.Size(1113, 597);
      this.splitContainer1.SplitterDistance = 371;
      this.splitContainer1.TabIndex = 18;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1113, 648);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panel1);
      this.Name = "FormMain";
      this.Text = "ISPVDemoKlient";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tabControl.ResumeLayout(false);
      this.tabPageLog.ResumeLayout(false);
      this.tabChybyMi.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChybyEkSubjektu)).EndInit();
      this.tabChybyMp.ResumeLayout(false);
      this.splitContainerChybyMp.Panel1.ResumeLayout(false);
      this.splitContainerChybyMp.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerChybyMp)).EndInit();
      this.splitContainerChybyMp.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPracovniPomery)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChybyPracovnihoPomeru)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btDostupnost;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPageLog;
    private System.Windows.Forms.TabPage tabChybyMp;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.Button btSelectXmlFile;
    private System.Windows.Forms.Label labelXmlFile;
    private System.Windows.Forms.Label lblXmlFileName;
    private System.IO.FileSystemWatcher fileSystemWatcher1;
    private System.Windows.Forms.RichTextBox textBox;
    private System.Windows.Forms.Button btOdeslatData;
    private System.Windows.Forms.Button btKontroly;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblJmeno;
    private System.Windows.Forms.TextBox textBoxZprava;
    private System.Windows.Forms.TextBox textBoxTelefon;
    private System.Windows.Forms.TextBox textBoxEmail;
    private System.Windows.Forms.TextBox textBoxJmeno;
    private System.Windows.Forms.Label lblZprava;
    private System.Windows.Forms.Label lblTelefon;
    private System.Windows.Forms.SplitContainer splitContainerChybyMp;
    private System.Windows.Forms.TabPage tabChybyMi;
    private System.Windows.Forms.DataGridView dataGridViewPracovniPomery;
    private System.Windows.Forms.DataGridView dataGridViewChybyPracovnihoPomeru;
    private System.Windows.Forms.DataGridView dataGridViewChybyEkSubjektu;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.SplitContainer splitContainer1;
  }
}

