namespace IF_FOOD
{
    partial class w_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            btn_EntrarAdm = new Button();
            tb_Senha = new TextBox();
            lbl_Senha = new Label();
            tb_U = new TextBox();
            lbl_U = new Label();
            cb_Adm = new CheckBox();
            SuspendLayout();
            // 
            // btn_EntrarAdm
            // 
            btn_EntrarAdm.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EntrarAdm.Location = new Point(143, 239);
            btn_EntrarAdm.Name = "btn_EntrarAdm";
            btn_EntrarAdm.Size = new Size(136, 51);
            btn_EntrarAdm.TabIndex = 13;
            btn_EntrarAdm.Text = "Entrar";
            btn_EntrarAdm.UseVisualStyleBackColor = true;
            btn_EntrarAdm.Click += btn_EntrarAdm_Click;
            // 
            // tb_Senha
            // 
            tb_Senha.Location = new Point(234, 183);
            tb_Senha.Name = "tb_Senha";
            tb_Senha.Size = new Size(181, 23);
            tb_Senha.TabIndex = 12;
            // 
            // lbl_Senha
            // 
            lbl_Senha.AutoSize = true;
            lbl_Senha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Senha.Location = new Point(143, 174);
            lbl_Senha.Name = "lbl_Senha";
            lbl_Senha.Size = new Size(85, 32);
            lbl_Senha.TabIndex = 11;
            lbl_Senha.Text = "Senha:";
            // 
            // tb_U
            // 
            tb_U.Location = new Point(234, 131);
            tb_U.Name = "tb_U";
            tb_U.Size = new Size(181, 23);
            tb_U.TabIndex = 10;
            // 
            // lbl_U
            // 
            lbl_U.AutoSize = true;
            lbl_U.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_U.Location = new Point(129, 122);
            lbl_U.Name = "lbl_U";
            lbl_U.Size = new Size(99, 32);
            lbl_U.TabIndex = 9;
            lbl_U.Text = "Usuário:";
            // 
            // cb_Adm
            // 
            cb_Adm.AutoSize = true;
            cb_Adm.Location = new Point(143, 214);
            cb_Adm.Name = "cb_Adm";
            cb_Adm.Size = new Size(102, 19);
            cb_Adm.TabIndex = 14;
            cb_Adm.Text = "Administrador";
            cb_Adm.UseVisualStyleBackColor = true;
            // 
            // w_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 321);
            Controls.Add(cb_Adm);
            Controls.Add(btn_EntrarAdm);
            Controls.Add(tb_Senha);
            Controls.Add(lbl_Senha);
            Controls.Add(tb_U);
            Controls.Add(lbl_U);
            Name = "w_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IF_FOOD - Restaurante";
            Load += w_Principal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_EntrarAdm;
        private TextBox tb_Senha;
        private Label lbl_Senha;
        private TextBox tb_U;
        private Label lbl_U;
        private CheckBox cb_Adm;
    }
}
