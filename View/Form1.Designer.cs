namespace AC4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up Year resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Gestioner = new Label();
            Year = new Label();
            Comarca = new Label();
            Poblation = new Label();
            ComboBoxYear = new ComboBox();
            ComboBoxComarca = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            TxtBoxPopulation = new TextBox();
            TxtBoxConsum = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TxtBoxTotal = new TextBox();
            TxtBoxActivities = new TextBox();
            TxtBoxDomestic = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            LBLCMB = new Label();
            LBLCMA = new Label();
            LBLCM = new Label();
            LBLPoblacio = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            Cuadro = new DataGridView();
            Positive = new ErrorProvider(components);
            Number = new ErrorProvider(components);
            Void = new ErrorProvider(components);
            BTNNext = new Button();
            BTNAfter = new Button();
            bttnPersist = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Cuadro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Positive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Number).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Void).BeginInit();
            SuspendLayout();
            // 
            // Gestioner
            // 
            Gestioner.AutoSize = true;
            Gestioner.Location = new Point(22, 38);
            Gestioner.Name = "Gestioner";
            Gestioner.Size = new Size(231, 15);
            Gestioner.TabIndex = 0;
            Gestioner.Text = "Gestió de dades demogràfiques de regions";
            // 
            // Year
            // 
            Year.AutoSize = true;
            Year.Location = new Point(26, 31);
            Year.Name = "Year";
            Year.Size = new Size(28, 15);
            Year.TabIndex = 1;
            Year.Text = "Year\r\n";
            // 
            // Comarca
            // 
            Comarca.AutoSize = true;
            Comarca.Location = new Point(184, 31);
            Comarca.Name = "Comarca";
            Comarca.Size = new Size(55, 15);
            Comarca.TabIndex = 2;
            Comarca.Text = "Comarca";
            // 
            // Poblation
            // 
            Poblation.AutoSize = true;
            Poblation.Location = new Point(384, 111);
            Poblation.Name = "Poblation";
            Poblation.Size = new Size(60, 15);
            Poblation.TabIndex = 3;
            Poblation.Text = "Población";
            // 
            // ComboBoxYear
            // 
            ComboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxYear.FormattingEnabled = true;
            ComboBoxYear.Items.AddRange(new object[] { "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050" });
            ComboBoxYear.Location = new Point(26, 49);
            ComboBoxYear.Name = "ComboBoxYear";
            ComboBoxYear.Size = new Size(121, 23);
            ComboBoxYear.TabIndex = 4;
            ComboBoxYear.Validating += YearText_Validating;
            // 
            // ComboBoxComarca
            // 
            ComboBoxComarca.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxComarca.FormattingEnabled = true;
            ComboBoxComarca.Location = new Point(184, 49);
            ComboBoxComarca.Name = "ComboBoxComarca";
            ComboBoxComarca.Size = new Size(121, 23);
            ComboBoxComarca.TabIndex = 5;
            ComboBoxComarca.Validating += ComarcaText_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 85);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 7;
            label1.Text = "Domèstic xarxa";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtBoxPopulation);
            groupBox1.Controls.Add(TxtBoxConsum);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtBoxTotal);
            groupBox1.Controls.Add(ComboBoxComarca);
            groupBox1.Controls.Add(Comarca);
            groupBox1.Controls.Add(TxtBoxActivities);
            groupBox1.Controls.Add(ComboBoxYear);
            groupBox1.Controls.Add(TxtBoxDomestic);
            groupBox1.Controls.Add(Year);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 229);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestió de dades demogràfiques de regions";
            groupBox1.UseCompatibleTextRendering = true;
            // 
            // TxtBoxPopulation
            // 
            TxtBoxPopulation.Location = new Point(372, 50);
            TxtBoxPopulation.Name = "TxtBoxPopulation";
            TxtBoxPopulation.Size = new Size(118, 23);
            TxtBoxPopulation.TabIndex = 15;
            TxtBoxPopulation.Validating += PoblacióText_Validating;
            // 
            // TxtBoxConsum
            // 
            TxtBoxConsum.Location = new Point(400, 116);
            TxtBoxConsum.Name = "TxtBoxConsum";
            TxtBoxConsum.Size = new Size(100, 23);
            TxtBoxConsum.TabIndex = 11;
            TxtBoxConsum.Validating += ConsumText_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 152);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 14;
            label4.Text = "Total\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 99);
            label3.Name = "label3";
            label3.Size = new Size(104, 30);
            label3.TabIndex = 13;
            label3.Text = "Consum domèstic\r\nper càpita\r\n";
            // 
            // TxtBoxTotal
            // 
            TxtBoxTotal.Location = new Point(400, 152);
            TxtBoxTotal.Name = "TxtBoxTotal";
            TxtBoxTotal.Size = new Size(100, 23);
            TxtBoxTotal.TabIndex = 12;
            TxtBoxTotal.Validating += TotalText_Validating;
            // 
            // TxtBoxActivities
            // 
            TxtBoxActivities.Location = new Point(184, 119);
            TxtBoxActivities.Name = "TxtBoxActivities";
            TxtBoxActivities.Size = new Size(100, 23);
            TxtBoxActivities.TabIndex = 10;
            TxtBoxActivities.Validating += ActivitatsText_Validating;
            // 
            // TxtBoxDomestic
            // 
            TxtBoxDomestic.Location = new Point(26, 119);
            TxtBoxDomestic.Name = "TxtBoxDomestic";
            TxtBoxDomestic.Size = new Size(100, 23);
            TxtBoxDomestic.TabIndex = 9;
            TxtBoxDomestic.Validating += DomésticText_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 85);
            label2.Name = "label2";
            label2.Size = new Size(131, 30);
            label2.TabIndex = 8;
            label2.Text = "Activitats econòmiques\r\ni fonts pròpies";
            // 
            // button1
            // 
            button1.Location = new Point(465, 332);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(369, 332);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Netejar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LBLCMB);
            groupBox2.Controls.Add(LBLCMA);
            groupBox2.Controls.Add(LBLCM);
            groupBox2.Controls.Add(LBLPoblacio);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Location = new Point(640, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(313, 135);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadístiques";
            groupBox2.UseCompatibleTextRendering = true;
            // 
            // LBLCMB
            // 
            LBLCMB.AutoSize = true;
            LBLCMB.ForeColor = Color.RoyalBlue;
            LBLCMB.Location = new Point(242, 111);
            LBLCMB.Name = "LBLCMB";
            LBLCMB.Size = new Size(44, 15);
            LBLCMB.TabIndex = 22;
            LBLCMB.Text = "label14";
            // 
            // LBLCMA
            // 
            LBLCMA.AutoSize = true;
            LBLCMA.ForeColor = Color.RoyalBlue;
            LBLCMA.Location = new Point(242, 82);
            LBLCMA.Name = "LBLCMA";
            LBLCMA.Size = new Size(44, 15);
            LBLCMA.TabIndex = 21;
            LBLCMA.Text = "label13";
            // 
            // LBLCM
            // 
            LBLCM.AutoSize = true;
            LBLCM.ForeColor = Color.RoyalBlue;
            LBLCM.Location = new Point(242, 53);
            LBLCM.Name = "LBLCM";
            LBLCM.Size = new Size(44, 15);
            LBLCM.TabIndex = 20;
            LBLCM.Text = "label12";
            // 
            // LBLPoblacio
            // 
            LBLPoblacio.AutoSize = true;
            LBLPoblacio.ForeColor = Color.RoyalBlue;
            LBLPoblacio.Location = new Point(242, 25);
            LBLPoblacio.Name = "LBLPoblacio";
            LBLPoblacio.Size = new Size(44, 15);
            LBLPoblacio.TabIndex = 19;
            LBLPoblacio.Text = "label11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 113);
            label10.Name = "label10";
            label10.Size = new Size(212, 15);
            label10.TabIndex = 18;
            label10.Text = "Consum domèstic per càpita més baix:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 82);
            label9.Name = "label9";
            label9.Size = new Size(203, 15);
            label9.TabIndex = 17;
            label9.Text = "Consum domèstic per càpita més alt:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 51);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 16;
            label8.Text = "Consum domèstic mitjà:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 25);
            label7.Name = "label7";
            label7.Size = new Size(126, 15);
            label7.TabIndex = 15;
            label7.Text = "Població > 20000 hab.:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(383, 149);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 14;
            label5.Text = "Total\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(358, 92);
            label6.Name = "label6";
            label6.Size = new Size(104, 30);
            label6.TabIndex = 13;
            label6.Text = "Consum domèstic\r\nper càpita\r\n";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(468, 146);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(468, 92);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 11;
            // 
            // Cuadro
            // 
            Cuadro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Cuadro.Location = new Point(56, 362);
            Cuadro.Name = "Cuadro";
            Cuadro.RowHeadersWidth = 51;
            Cuadro.Size = new Size(1034, 234);
            Cuadro.TabIndex = 16;
            // 
            // Positive
            // 
            Positive.ContainerControl = this;
            // 
            // Number
            // 
            Number.ContainerControl = this;
            // 
            // Void
            // 
            Void.ContainerControl = this;
            // 
            // BTNNext
            // 
            BTNNext.Location = new Point(196, 617);
            BTNNext.Margin = new Padding(3, 2, 3, 2);
            BTNNext.Name = "BTNNext";
            BTNNext.Size = new Size(82, 22);
            BTNNext.TabIndex = 17;
            BTNNext.Text = "-->";
            BTNNext.UseVisualStyleBackColor = true;
            BTNNext.Click += BTNNext_Click_1;
            // 
            // BTNAfter
            // 
            BTNAfter.Location = new Point(93, 617);
            BTNAfter.Margin = new Padding(3, 2, 3, 2);
            BTNAfter.Name = "BTNAfter";
            BTNAfter.Size = new Size(82, 22);
            BTNAfter.TabIndex = 18;
            BTNAfter.Text = "<--";
            BTNAfter.UseVisualStyleBackColor = true;
            BTNAfter.Click += BTNAfter_Click_1;
            // 
            // bttnPersist
            // 
            bttnPersist.Location = new Point(998, 332);
            bttnPersist.Name = "bttnPersist";
            bttnPersist.Size = new Size(75, 23);
            bttnPersist.TabIndex = 19;
            bttnPersist.Text = "Persistir";
            bttnPersist.UseVisualStyleBackColor = true;
            bttnPersist.Click += bttnPersist_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1110, 658);
            Controls.Add(bttnPersist);
            Controls.Add(BTNAfter);
            Controls.Add(BTNNext);
            Controls.Add(Cuadro);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Poblation);
            Controls.Add(Gestioner);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = " ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Cuadro).EndInit();
            ((System.ComponentModel.ISupportInitialize)Positive).EndInit();
            ((System.ComponentModel.ISupportInitialize)Number).EndInit();
            ((System.ComponentModel.ISupportInitialize)Void).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Gestioner;
        private Label Year;
        private Label Comarca;
        private Label Poblation;
        private ComboBox ComboBoxYear;
        private ComboBox ComboBoxComarca;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox TxtBoxActivities;
        private TextBox TxtBoxDomestic;
        private Label label4;
        private Label label3;
        private TextBox TxtBoxTotal;
        private TextBox TxtBoxConsum;
        private Button button1;
        private Button button2;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label LBLCM;
        private Label LBLPoblacio;
        private Label LBLCMB;
        private Label LBLCMA;
        private TextBox TxtBoxPopulation;
        private DataGridView Cuadro;
        private ErrorProvider Positive;
        private ErrorProvider Number;
        private ErrorProvider Void;
        private Button BTNAfter;
        private Button BTNNext;
        private Button bttnPersist;
    }
}
