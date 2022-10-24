namespace Scrittori_Visione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox_Nick = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Colore = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_grassetto = new System.Windows.Forms.CheckBox();
            this.checkBox_corsivo = new System.Windows.Forms.CheckBox();
            this.checkBox_sottolineato = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.butn_aggiungi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(309, 31);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(479, 389);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox_Nick
            // 
            this.textBox_Nick.Location = new System.Drawing.Point(29, 82);
            this.textBox_Nick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Nick.Multiline = true;
            this.textBox_Nick.Name = "textBox_Nick";
            this.textBox_Nick.Size = new System.Drawing.Size(172, 25);
            this.textBox_Nick.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scrittore:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Visualizzatore:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_Colore
            // 
            this.comboBox_Colore.FormattingEnabled = true;
            this.comboBox_Colore.Items.AddRange(new object[] {
            "ROSSO",
            "VERDE",
            "BLU"});
            this.comboBox_Colore.Location = new System.Drawing.Point(29, 283);
            this.comboBox_Colore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Colore.Name = "comboBox_Colore";
            this.comboBox_Colore.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Colore.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Colore:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nickname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, -41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 663);
            this.label5.TabIndex = 7;
            this.label5.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n" +
    "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Font:";
            // 
            // checkBox_grassetto
            // 
            this.checkBox_grassetto.AutoSize = true;
            this.checkBox_grassetto.Location = new System.Drawing.Point(31, 159);
            this.checkBox_grassetto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_grassetto.Name = "checkBox_grassetto";
            this.checkBox_grassetto.Size = new System.Drawing.Size(92, 21);
            this.checkBox_grassetto.TabIndex = 11;
            this.checkBox_grassetto.Text = "Grassetto";
            this.checkBox_grassetto.UseVisualStyleBackColor = true;
            // 
            // checkBox_corsivo
            // 
            this.checkBox_corsivo.AutoSize = true;
            this.checkBox_corsivo.Location = new System.Drawing.Point(29, 187);
            this.checkBox_corsivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_corsivo.Name = "checkBox_corsivo";
            this.checkBox_corsivo.Size = new System.Drawing.Size(77, 21);
            this.checkBox_corsivo.TabIndex = 12;
            this.checkBox_corsivo.Text = "Corsivo";
            this.checkBox_corsivo.UseVisualStyleBackColor = true;
            // 
            // checkBox_sottolineato
            // 
            this.checkBox_sottolineato.AutoSize = true;
            this.checkBox_sottolineato.Location = new System.Drawing.Point(29, 215);
            this.checkBox_sottolineato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_sottolineato.Name = "checkBox_sottolineato";
            this.checkBox_sottolineato.Size = new System.Drawing.Size(105, 21);
            this.checkBox_sottolineato.TabIndex = 13;
            this.checkBox_sottolineato.Text = "Sottolineato";
            this.checkBox_sottolineato.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 358);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 62);
            this.textBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 338);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Messaggio:";
            // 
            // butn_aggiungi
            // 
            this.butn_aggiungi.Location = new System.Drawing.Point(29, 457);
            this.butn_aggiungi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butn_aggiungi.Name = "butn_aggiungi";
            this.butn_aggiungi.Size = new System.Drawing.Size(161, 41);
            this.butn_aggiungi.TabIndex = 16;
            this.butn_aggiungi.Text = "Aggiungi";
            this.butn_aggiungi.UseVisualStyleBackColor = true;
            this.butn_aggiungi.Click += new System.EventHandler(this.butn_aggiungi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 572);
            this.Controls.Add(this.butn_aggiungi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox_sottolineato);
            this.Controls.Add(this.checkBox_corsivo);
            this.Controls.Add(this.checkBox_grassetto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Colore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Nick);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox_Nick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Colore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_grassetto;
        private System.Windows.Forms.CheckBox checkBox_corsivo;
        private System.Windows.Forms.CheckBox checkBox_sottolineato;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butn_aggiungi;
    }
}

