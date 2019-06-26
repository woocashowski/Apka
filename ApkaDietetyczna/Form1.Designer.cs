namespace ApkaDietetyczna
{
    partial class AplikacjaDietetyczna
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Age1 = new System.Windows.Forms.TextBox();
            this.Growth1 = new System.Windows.Forms.TextBox();
            this.Weight1 = new System.Windows.Forms.TextBox();
            this.Plec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.Kalorie = new System.Windows.Forms.Label();
            this.PracaFizyczna = new System.Windows.Forms.CheckBox();
            this.comboBoxPracaFizyczna = new System.Windows.Forms.ComboBox();
            this.PracaStojaco = new System.Windows.Forms.CheckBox();
            this.comboBoxPracaStojaca = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Walking = new System.Windows.Forms.ComboBox();
            this.Sit = new System.Windows.Forms.CheckBox();
            this.SztukiWalki = new System.Windows.Forms.CheckBox();
            this.MartialArts = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Cycling = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DodatkowaAktyw = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Produkty = new System.Windows.Forms.ListBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.StrengthTraining = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Sylwetka = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Cele = new System.Windows.Forms.ComboBox();
            this.Szaczowa = new System.Windows.Forms.Label();
            this.TimeToCele = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxBMI = new System.Windows.Forms.TextBox();
            this.LabelBMI = new System.Windows.Forms.Label();
            this.BMINapis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // Age1
            // 
            this.Age1.Location = new System.Drawing.Point(90, 63);
            this.Age1.Name = "Age1";
            this.Age1.Size = new System.Drawing.Size(100, 20);
            this.Age1.TabIndex = 1;
            this.Age1.TextChanged += new System.EventHandler(this.Age1_TextChanged);
            // 
            // Growth1
            // 
            this.Growth1.Location = new System.Drawing.Point(90, 89);
            this.Growth1.Name = "Growth1";
            this.Growth1.Size = new System.Drawing.Size(100, 20);
            this.Growth1.TabIndex = 2;
            // 
            // Weight1
            // 
            this.Weight1.Location = new System.Drawing.Point(90, 115);
            this.Weight1.Name = "Weight1";
            this.Weight1.Size = new System.Drawing.Size(100, 20);
            this.Weight1.TabIndex = 3;
            this.Weight1.TextChanged += new System.EventHandler(this.Weight1_TextChanged);
            // 
            // Plec
            // 
            this.Plec.FormattingEnabled = true;
            this.Plec.Location = new System.Drawing.Point(90, 37);
            this.Plec.Margin = new System.Windows.Forms.Padding(2);
            this.Plec.Name = "Plec";
            this.Plec.Size = new System.Drawing.Size(100, 21);
            this.Plec.TabIndex = 5;
            this.Plec.SelectedIndexChanged += new System.EventHandler(this.Plec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Płeć";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wiek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wzrost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Waga";
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(13, 516);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(59, 24);
            this.Button.TabIndex = 10;
            this.Button.Text = "OK";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(156, 561);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 11;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // Kalorie
            // 
            this.Kalorie.AutoSize = true;
            this.Kalorie.Location = new System.Drawing.Point(11, 567);
            this.Kalorie.Name = "Kalorie";
            this.Kalorie.Size = new System.Drawing.Size(117, 13);
            this.Kalorie.TabIndex = 12;
            this.Kalorie.Text = "Zalecana kaloryczność";
            // 
            // PracaFizyczna
            // 
            this.PracaFizyczna.AutoSize = true;
            this.PracaFizyczna.Location = new System.Drawing.Point(13, 308);
            this.PracaFizyczna.Name = "PracaFizyczna";
            this.PracaFizyczna.Size = new System.Drawing.Size(98, 17);
            this.PracaFizyczna.TabIndex = 13;
            this.PracaFizyczna.Text = "Praca fizyczna ";
            this.PracaFizyczna.UseVisualStyleBackColor = true;
            this.PracaFizyczna.CheckedChanged += new System.EventHandler(this.PracaFizyczna_CheckedChanged);
            // 
            // comboBoxPracaFizyczna
            // 
            this.comboBoxPracaFizyczna.FormattingEnabled = true;
            this.comboBoxPracaFizyczna.Location = new System.Drawing.Point(173, 308);
            this.comboBoxPracaFizyczna.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPracaFizyczna.Name = "comboBoxPracaFizyczna";
            this.comboBoxPracaFizyczna.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPracaFizyczna.TabIndex = 14;
            this.comboBoxPracaFizyczna.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPracaFizyczna_SelectedIndexChanged);
            // 
            // PracaStojaco
            // 
            this.PracaStojaco.AutoSize = true;
            this.PracaStojaco.Location = new System.Drawing.Point(13, 331);
            this.PracaStojaco.Name = "PracaStojaco";
            this.PracaStojaco.Size = new System.Drawing.Size(91, 17);
            this.PracaStojaco.TabIndex = 15;
            this.PracaStojaco.Text = "Praca stojąca";
            this.PracaStojaco.UseVisualStyleBackColor = true;
            this.PracaStojaco.CheckedChanged += new System.EventHandler(this.PracaStojaco_CheckedChanged);
            // 
            // comboBoxPracaStojaca
            // 
            this.comboBoxPracaStojaca.FormattingEnabled = true;
            this.comboBoxPracaStojaca.Location = new System.Drawing.Point(173, 333);
            this.comboBoxPracaStojaca.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPracaStojaca.Name = "comboBoxPracaStojaca";
            this.comboBoxPracaStojaca.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPracaStojaca.TabIndex = 16;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 383);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Poruszanie się Pieszo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Walking
            // 
            this.Walking.FormattingEnabled = true;
            this.Walking.Location = new System.Drawing.Point(173, 377);
            this.Walking.Margin = new System.Windows.Forms.Padding(2);
            this.Walking.Name = "Walking";
            this.Walking.Size = new System.Drawing.Size(100, 21);
            this.Walking.TabIndex = 18;
            this.Walking.SelectedIndexChanged += new System.EventHandler(this.Walking_SelectedIndexChanged);
            // 
            // Sit
            // 
            this.Sit.AutoSize = true;
            this.Sit.Location = new System.Drawing.Point(12, 354);
            this.Sit.Name = "Sit";
            this.Sit.Size = new System.Drawing.Size(101, 17);
            this.Sit.TabIndex = 19;
            this.Sit.Text = "Praca Siedząca";
            this.Sit.UseVisualStyleBackColor = true;
            this.Sit.CheckedChanged += new System.EventHandler(this.Sit_CheckedChanged);
            this.Sit.Click += new System.EventHandler(this.Sit_Click);
            // 
            // SztukiWalki
            // 
            this.SztukiWalki.AutoSize = true;
            this.SztukiWalki.Location = new System.Drawing.Point(12, 406);
            this.SztukiWalki.Name = "SztukiWalki";
            this.SztukiWalki.Size = new System.Drawing.Size(85, 17);
            this.SztukiWalki.TabIndex = 20;
            this.SztukiWalki.Text = "Sztuki Walki";
            this.SztukiWalki.UseVisualStyleBackColor = true;
            this.SztukiWalki.CheckedChanged += new System.EventHandler(this.SztukiWalki_CheckedChanged);
            // 
            // MartialArts
            // 
            this.MartialArts.FormattingEnabled = true;
            this.MartialArts.Location = new System.Drawing.Point(173, 402);
            this.MartialArts.Margin = new System.Windows.Forms.Padding(2);
            this.MartialArts.Name = "MartialArts";
            this.MartialArts.Size = new System.Drawing.Size(100, 21);
            this.MartialArts.TabIndex = 21;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 431);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(109, 17);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "Jazda na rowerze";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // Cycling
            // 
            this.Cycling.FormattingEnabled = true;
            this.Cycling.Location = new System.Drawing.Point(173, 427);
            this.Cycling.Margin = new System.Windows.Forms.Padding(2);
            this.Cycling.Name = "Cycling";
            this.Cycling.Size = new System.Drawing.Size(100, 21);
            this.Cycling.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Proszę podać swoje prawdziwe dane";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Proszę podać swoją aktywność na przestrzeni tygodnia";
            // 
            // DodatkowaAktyw
            // 
            this.DodatkowaAktyw.AutoSize = true;
            this.DodatkowaAktyw.Location = new System.Drawing.Point(13, 493);
            this.DodatkowaAktyw.Name = "DodatkowaAktyw";
            this.DodatkowaAktyw.Size = new System.Drawing.Size(230, 17);
            this.DodatkowaAktyw.TabIndex = 26;
            this.DodatkowaAktyw.Text = "Dodatkowa aktywność, której nie ma wyżej";
            this.DodatkowaAktyw.UseVisualStyleBackColor = true;
            this.DodatkowaAktyw.CheckedChanged += new System.EventHandler(this.DodatkowaAktyw_CheckedChanged);
            this.DodatkowaAktyw.Click += new System.EventHandler(this.DodatkowaAktyw_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Zalecane produkty do spożycia";
            // 
            // Produkty
            // 
            this.Produkty.FormattingEnabled = true;
            this.Produkty.Location = new System.Drawing.Point(321, 37);
            this.Produkty.Name = "Produkty";
            this.Produkty.Size = new System.Drawing.Size(360, 420);
            this.Produkty.TabIndex = 28;
            this.Produkty.SelectedIndexChanged += new System.EventHandler(this.Produkty_SelectedIndexChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(13, 459);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(95, 17);
            this.checkBox4.TabIndex = 29;
            this.checkBox4.Text = "Trening siłowy";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // StrengthTraining
            // 
            this.StrengthTraining.FormattingEnabled = true;
            this.StrengthTraining.Location = new System.Drawing.Point(173, 457);
            this.StrengthTraining.Margin = new System.Windows.Forms.Padding(2);
            this.StrengthTraining.Name = "StrengthTraining";
            this.StrengthTraining.Size = new System.Drawing.Size(100, 21);
            this.StrengthTraining.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Odpowiedz na pytania";
            // 
            // Sylwetka
            // 
            this.Sylwetka.FormattingEnabled = true;
            this.Sylwetka.Location = new System.Drawing.Point(177, 177);
            this.Sylwetka.Margin = new System.Windows.Forms.Padding(2);
            this.Sylwetka.Name = "Sylwetka";
            this.Sylwetka.Size = new System.Drawing.Size(100, 21);
            this.Sylwetka.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Twój typ sylwetki";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Twoje cele";
            // 
            // Cele
            // 
            this.Cele.FormattingEnabled = true;
            this.Cele.Location = new System.Drawing.Point(177, 209);
            this.Cele.Margin = new System.Windows.Forms.Padding(2);
            this.Cele.Name = "Cele";
            this.Cele.Size = new System.Drawing.Size(100, 21);
            this.Cele.TabIndex = 35;
            // 
            // Szaczowa
            // 
            this.Szaczowa.AutoSize = true;
            this.Szaczowa.Location = new System.Drawing.Point(12, 238);
            this.Szaczowa.Name = "Szaczowa";
            this.Szaczowa.Size = new System.Drawing.Size(124, 13);
            this.Szaczowa.TabIndex = 36;
            this.Szaczowa.Text = "Czas na osiągnięcie celu";
            // 
            // TimeToCele
            // 
            this.TimeToCele.FormattingEnabled = true;
            this.TimeToCele.Location = new System.Drawing.Point(177, 238);
            this.TimeToCele.Margin = new System.Windows.Forms.Padding(2);
            this.TimeToCele.Name = "TimeToCele";
            this.TimeToCele.Size = new System.Drawing.Size(100, 21);
            this.TimeToCele.TabIndex = 37;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // textBoxBMI
            // 
            this.textBoxBMI.Location = new System.Drawing.Point(385, 491);
            this.textBoxBMI.Name = "textBoxBMI";
            this.textBoxBMI.Size = new System.Drawing.Size(45, 20);
            this.textBoxBMI.TabIndex = 38;
            // 
            // LabelBMI
            // 
            this.LabelBMI.AutoSize = true;
            this.LabelBMI.Location = new System.Drawing.Point(318, 494);
            this.LabelBMI.Name = "LabelBMI";
            this.LabelBMI.Size = new System.Drawing.Size(61, 13);
            this.LabelBMI.TabIndex = 39;
            this.LabelBMI.Text = "Twoje BMI:";
            // 
            // BMINapis
            // 
            this.BMINapis.AutoSize = true;
            this.BMINapis.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMINapis.Location = new System.Drawing.Point(341, 527);
            this.BMINapis.Name = "BMINapis";
            this.BMINapis.Size = new System.Drawing.Size(0, 38);
            this.BMINapis.TabIndex = 40;
            // 
            // AplikacjaDietetyczna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(709, 635);
            this.Controls.Add(this.BMINapis);
            this.Controls.Add(this.LabelBMI);
            this.Controls.Add(this.textBoxBMI);
            this.Controls.Add(this.TimeToCele);
            this.Controls.Add(this.Szaczowa);
            this.Controls.Add(this.Cele);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Sylwetka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StrengthTraining);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.Produkty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DodatkowaAktyw);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cycling);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.MartialArts);
            this.Controls.Add(this.SztukiWalki);
            this.Controls.Add(this.Sit);
            this.Controls.Add(this.Walking);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBoxPracaStojaca);
            this.Controls.Add(this.PracaStojaco);
            this.Controls.Add(this.comboBoxPracaFizyczna);
            this.Controls.Add(this.PracaFizyczna);
            this.Controls.Add(this.Kalorie);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Plec);
            this.Controls.Add(this.Weight1);
            this.Controls.Add(this.Growth1);
            this.Controls.Add(this.Age1);
            this.Name = "AplikacjaDietetyczna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikacja Dietetyczna";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Age1;
        private System.Windows.Forms.TextBox Growth1;
        private System.Windows.Forms.TextBox Weight1;
        private System.Windows.Forms.ComboBox Plec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label Kalorie;
        private System.Windows.Forms.CheckBox PracaFizyczna;
        private System.Windows.Forms.ComboBox comboBoxPracaFizyczna;
        private System.Windows.Forms.CheckBox PracaStojaco;
        private System.Windows.Forms.ComboBox comboBoxPracaStojaca;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox Walking;
        private System.Windows.Forms.CheckBox Sit;
        private System.Windows.Forms.CheckBox SztukiWalki;
        private System.Windows.Forms.ComboBox MartialArts;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox Cycling;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox DodatkowaAktyw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Produkty;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ComboBox StrengthTraining;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Sylwetka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Cele;
        private System.Windows.Forms.Label Szaczowa;
        private System.Windows.Forms.ComboBox TimeToCele;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label LabelBMI;
        private System.Windows.Forms.TextBox textBoxBMI;
        private System.Windows.Forms.Label BMINapis;
    }
}

