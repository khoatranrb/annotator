namespace rate_image
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
            this.txt_label = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.Label();
            this.txt_gender = new System.Windows.Forms.Label();
            this.txt_short_sight = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.cb_male = new System.Windows.Forms.CheckBox();
            this.cb_female = new System.Windows.Forms.CheckBox();
            this.cb_yes = new System.Windows.Forms.CheckBox();
            this.cb_no = new System.Windows.Forms.CheckBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_label
            // 
            this.txt_label.AutoSize = true;
            this.txt_label.Location = new System.Drawing.Point(353, 35);
            this.txt_label.Name = "txt_label";
            this.txt_label.Size = new System.Drawing.Size(112, 16);
            this.txt_label.TabIndex = 0;
            this.txt_label.Text = "Thông tin cá nhân";
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Location = new System.Drawing.Point(261, 80);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(31, 16);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "Tên";
            // 
            // txt_age
            // 
            this.txt_age.AutoSize = true;
            this.txt_age.Location = new System.Drawing.Point(264, 136);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(34, 16);
            this.txt_age.TabIndex = 2;
            this.txt_age.Text = "Tuổi";
            // 
            // txt_gender
            // 
            this.txt_gender.AutoSize = true;
            this.txt_gender.Location = new System.Drawing.Point(261, 190);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(54, 16);
            this.txt_gender.TabIndex = 3;
            this.txt_gender.Text = "Giới tính";
            // 
            // txt_short_sight
            // 
            this.txt_short_sight.AutoSize = true;
            this.txt_short_sight.Location = new System.Drawing.Point(261, 258);
            this.txt_short_sight.Name = "txt_short_sight";
            this.txt_short_sight.Size = new System.Drawing.Size(124, 16);
            this.txt_short_sight.TabIndex = 4;
            this.txt_short_sight.Text = "Có cận hay không ?";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(264, 99);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(279, 22);
            this.tb_name.TabIndex = 5;
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(264, 155);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(279, 22);
            this.tb_age.TabIndex = 6;
            // 
            // cb_male
            // 
            this.cb_male.AutoSize = true;
            this.cb_male.Location = new System.Drawing.Point(264, 218);
            this.cb_male.Name = "cb_male";
            this.cb_male.Size = new System.Drawing.Size(58, 20);
            this.cb_male.TabIndex = 7;
            this.cb_male.Text = "Nam";
            this.cb_male.UseVisualStyleBackColor = true;
            this.cb_male.CheckedChanged += new System.EventHandler(this.cb_male_CheckedChanged);
            // 
            // cb_female
            // 
            this.cb_female.AutoSize = true;
            this.cb_female.Location = new System.Drawing.Point(434, 218);
            this.cb_female.Name = "cb_female";
            this.cb_female.Size = new System.Drawing.Size(46, 20);
            this.cb_female.TabIndex = 8;
            this.cb_female.Text = "Nữ";
            this.cb_female.UseVisualStyleBackColor = true;
            this.cb_female.CheckedChanged += new System.EventHandler(this.cb_female_CheckedChanged);
            // 
            // cb_yes
            // 
            this.cb_yes.AutoSize = true;
            this.cb_yes.Location = new System.Drawing.Point(264, 289);
            this.cb_yes.Name = "cb_yes";
            this.cb_yes.Size = new System.Drawing.Size(46, 20);
            this.cb_yes.TabIndex = 9;
            this.cb_yes.Text = "Có";
            this.cb_yes.UseVisualStyleBackColor = true;
            this.cb_yes.CheckedChanged += new System.EventHandler(this.cb_yes_CheckedChanged);
            // 
            // cb_no
            // 
            this.cb_no.AutoSize = true;
            this.cb_no.Location = new System.Drawing.Point(434, 289);
            this.cb_no.Name = "cb_no";
            this.cb_no.Size = new System.Drawing.Size(67, 20);
            this.cb_no.TabIndex = 10;
            this.cb_no.Text = "Không";
            this.cb_no.UseVisualStyleBackColor = true;
            this.cb_no.CheckedChanged += new System.EventHandler(this.cb_no_CheckedChanged);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(356, 355);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(109, 23);
            this.btn_next.TabIndex = 11;
            this.btn_next.Text = "Tiếp";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.cb_no);
            this.Controls.Add(this.cb_yes);
            this.Controls.Add(this.cb_female);
            this.Controls.Add(this.cb_male);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.txt_short_sight);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_label;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Label txt_age;
        private System.Windows.Forms.Label txt_gender;
        private System.Windows.Forms.Label txt_short_sight;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.CheckBox cb_male;
        private System.Windows.Forms.CheckBox cb_female;
        private System.Windows.Forms.CheckBox cb_yes;
        private System.Windows.Forms.CheckBox cb_no;
        private System.Windows.Forms.Button btn_next;
    }
}

