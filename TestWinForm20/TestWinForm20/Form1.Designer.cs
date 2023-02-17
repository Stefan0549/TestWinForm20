namespace TestWinForm20
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_avtor = new System.Windows.Forms.TextBox();
            this.txt_zaglavie = new System.Windows.Forms.TextBox();
            this.combo_izdatelstvo = new System.Windows.Forms.ComboBox();
            this.lbl_avtor = new System.Windows.Forms.Label();
            this.lbl_zaglavie = new System.Windows.Forms.Label();
            this.lbl_izdatelstvo = new System.Windows.Forms.Label();
            this.lbl_janr = new System.Windows.Forms.Label();
            this.lbl_korica = new System.Windows.Forms.Label();
            this.group_janr = new System.Windows.Forms.GroupBox();
            this.check_nauchno = new System.Windows.Forms.CheckBox();
            this.check_hudojestvena = new System.Windows.Forms.CheckBox();
            this.radio_meka = new System.Windows.Forms.RadioButton();
            this.radio_tvurda = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_spravochna = new System.Windows.Forms.CheckBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.lbl_egn = new System.Windows.Forms.Label();
            this.txt_egn = new System.Windows.Forms.TextBox();
            this.group_janr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_avtor
            // 
            this.txt_avtor.Location = new System.Drawing.Point(154, 43);
            this.txt_avtor.Name = "txt_avtor";
            this.txt_avtor.Size = new System.Drawing.Size(216, 22);
            this.txt_avtor.TabIndex = 0;
            // 
            // txt_zaglavie
            // 
            this.txt_zaglavie.Location = new System.Drawing.Point(154, 111);
            this.txt_zaglavie.Name = "txt_zaglavie";
            this.txt_zaglavie.Size = new System.Drawing.Size(216, 22);
            this.txt_zaglavie.TabIndex = 1;
            // 
            // combo_izdatelstvo
            // 
            this.combo_izdatelstvo.FormattingEnabled = true;
            this.combo_izdatelstvo.Items.AddRange(new object[] {
            "Просвета",
            "Архимед",
            "Бг учебник"});
            this.combo_izdatelstvo.Location = new System.Drawing.Point(154, 170);
            this.combo_izdatelstvo.Name = "combo_izdatelstvo";
            this.combo_izdatelstvo.Size = new System.Drawing.Size(216, 24);
            this.combo_izdatelstvo.TabIndex = 2;
            // 
            // lbl_avtor
            // 
            this.lbl_avtor.Location = new System.Drawing.Point(12, 46);
            this.lbl_avtor.Name = "lbl_avtor";
            this.lbl_avtor.Size = new System.Drawing.Size(100, 23);
            this.lbl_avtor.TabIndex = 5;
            this.lbl_avtor.Text = "Автор";
            // 
            // lbl_zaglavie
            // 
            this.lbl_zaglavie.Location = new System.Drawing.Point(12, 114);
            this.lbl_zaglavie.Name = "lbl_zaglavie";
            this.lbl_zaglavie.Size = new System.Drawing.Size(100, 23);
            this.lbl_zaglavie.TabIndex = 6;
            this.lbl_zaglavie.Text = "Заглавие";
            // 
            // lbl_izdatelstvo
            // 
            this.lbl_izdatelstvo.Location = new System.Drawing.Point(12, 173);
            this.lbl_izdatelstvo.Name = "lbl_izdatelstvo";
            this.lbl_izdatelstvo.Size = new System.Drawing.Size(100, 23);
            this.lbl_izdatelstvo.TabIndex = 7;
            this.lbl_izdatelstvo.Text = "Издателство";
            // 
            // lbl_janr
            // 
            this.lbl_janr.Location = new System.Drawing.Point(442, 69);
            this.lbl_janr.Name = "lbl_janr";
            this.lbl_janr.Size = new System.Drawing.Size(100, 23);
            this.lbl_janr.TabIndex = 8;
            this.lbl_janr.Text = "Жанр";
            this.lbl_janr.Click += new System.EventHandler(this.lbl_janr_Click);
            // 
            // lbl_korica
            // 
            this.lbl_korica.Location = new System.Drawing.Point(424, 229);
            this.lbl_korica.Name = "lbl_korica";
            this.lbl_korica.Size = new System.Drawing.Size(136, 23);
            this.lbl_korica.TabIndex = 9;
            this.lbl_korica.Text = "Вид на корицата";
            // 
            // group_janr
            // 
            this.group_janr.Controls.Add(this.check_spravochna);
            this.group_janr.Controls.Add(this.check_nauchno);
            this.group_janr.Controls.Add(this.check_hudojestvena);
            this.group_janr.Location = new System.Drawing.Point(590, 12);
            this.group_janr.Name = "group_janr";
            this.group_janr.Size = new System.Drawing.Size(335, 152);
            this.group_janr.TabIndex = 10;
            this.group_janr.TabStop = false;
            // 
            // check_nauchno
            // 
            this.check_nauchno.AutoSize = true;
            this.check_nauchno.Location = new System.Drawing.Point(18, 56);
            this.check_nauchno.Name = "check_nauchno";
            this.check_nauchno.Size = new System.Drawing.Size(154, 20);
            this.check_nauchno.TabIndex = 1;
            this.check_nauchno.Text = "Научно-популярна";
            this.check_nauchno.UseVisualStyleBackColor = true;
            // 
            // check_hudojestvena
            // 
            this.check_hudojestvena.AutoSize = true;
            this.check_hudojestvena.Location = new System.Drawing.Point(18, 19);
            this.check_hudojestvena.Name = "check_hudojestvena";
            this.check_hudojestvena.Size = new System.Drawing.Size(124, 20);
            this.check_hudojestvena.TabIndex = 0;
            this.check_hudojestvena.Text = "Художествена";
            this.check_hudojestvena.UseVisualStyleBackColor = true;
            // 
            // radio_meka
            // 
            this.radio_meka.AutoSize = true;
            this.radio_meka.Location = new System.Drawing.Point(18, 21);
            this.radio_meka.Name = "radio_meka";
            this.radio_meka.Size = new System.Drawing.Size(62, 20);
            this.radio_meka.TabIndex = 11;
            this.radio_meka.TabStop = true;
            this.radio_meka.Text = "Мека";
            this.radio_meka.UseVisualStyleBackColor = true;
            // 
            // radio_tvurda
            // 
            this.radio_tvurda.AutoSize = true;
            this.radio_tvurda.Location = new System.Drawing.Point(18, 57);
            this.radio_tvurda.Name = "radio_tvurda";
            this.radio_tvurda.Size = new System.Drawing.Size(78, 20);
            this.radio_tvurda.TabIndex = 12;
            this.radio_tvurda.TabStop = true;
            this.radio_tvurda.Text = "Твърда";
            this.radio_tvurda.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_meka);
            this.groupBox1.Controls.Add(this.radio_tvurda);
            this.groupBox1.Location = new System.Drawing.Point(590, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 99);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // check_spravochna
            // 
            this.check_spravochna.AutoSize = true;
            this.check_spravochna.Location = new System.Drawing.Point(18, 99);
            this.check_spravochna.Name = "check_spravochna";
            this.check_spravochna.Size = new System.Drawing.Size(102, 20);
            this.check_spravochna.TabIndex = 2;
            this.check_spravochna.Text = "Справочна";
            this.check_spravochna.UseVisualStyleBackColor = true;
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(12, 322);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(935, 116);
            this.btn_enter.TabIndex = 14;
            this.btn_enter.Text = "Въведи";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // lbl_egn
            // 
            this.lbl_egn.AutoSize = true;
            this.lbl_egn.Location = new System.Drawing.Point(12, 229);
            this.lbl_egn.Name = "lbl_egn";
            this.lbl_egn.Size = new System.Drawing.Size(35, 16);
            this.lbl_egn.TabIndex = 15;
            this.lbl_egn.Text = "ЕГН";
            // 
            // txt_egn
            // 
            this.txt_egn.Location = new System.Drawing.Point(154, 229);
            this.txt_egn.Name = "txt_egn";
            this.txt_egn.Size = new System.Drawing.Size(216, 22);
            this.txt_egn.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.txt_egn);
            this.Controls.Add(this.lbl_egn);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group_janr);
            this.Controls.Add(this.lbl_korica);
            this.Controls.Add(this.lbl_janr);
            this.Controls.Add(this.lbl_izdatelstvo);
            this.Controls.Add(this.lbl_zaglavie);
            this.Controls.Add(this.lbl_avtor);
            this.Controls.Add(this.combo_izdatelstvo);
            this.Controls.Add(this.txt_zaglavie);
            this.Controls.Add(this.txt_avtor);
            this.Name = "Form1";
            this.Text = "Книга";
            this.group_janr.ResumeLayout(false);
            this.group_janr.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_avtor;
        private System.Windows.Forms.TextBox txt_zaglavie;
        private System.Windows.Forms.ComboBox combo_izdatelstvo;
        private System.Windows.Forms.Label lbl_avtor;
        private System.Windows.Forms.Label lbl_zaglavie;
        private System.Windows.Forms.Label lbl_izdatelstvo;
        private System.Windows.Forms.Label lbl_janr;
        private System.Windows.Forms.Label lbl_korica;
        private System.Windows.Forms.GroupBox group_janr;
        private System.Windows.Forms.CheckBox check_nauchno;
        private System.Windows.Forms.CheckBox check_hudojestvena;
        private System.Windows.Forms.RadioButton radio_meka;
        private System.Windows.Forms.RadioButton radio_tvurda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox check_spravochna;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label lbl_egn;
        private System.Windows.Forms.TextBox txt_egn;
    }
}

