namespace WinFormsTabla
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            richTextBoxResultados = new RichTextBox();
            buttonVer = new Button();
            textBoxNum = new TextBox();
            labelnumero = new Label();
            labeltitle = new Label();
            textBoxName = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(richTextBoxResultados);
            panel1.Controls.Add(buttonVer);
            panel1.Controls.Add(textBoxNum);
            panel1.Controls.Add(labelnumero);
            panel1.Controls.Add(labeltitle);
            panel1.Location = new Point(13, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 420);
            panel1.TabIndex = 0;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Location = new Point(348, 130);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(133, 217);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVer.Location = new Point(157, 228);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(94, 29);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "Ver Tabla";
            buttonVer.UseVisualStyleBackColor = true;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(143, 175);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(125, 27);
            textBoxNum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelnumero.Location = new Point(114, 128);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(203, 26);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "Cual tabla deseas?";
            // 
            // labeltitle
            // 
            labeltitle.AutoSize = true;
            labeltitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labeltitle.Location = new Point(233, 33);
            labeltitle.Name = "labeltitle";
            labeltitle.Size = new Size(234, 31);
            labeltitle.TabIndex = 0;
            labeltitle.Text = "Tabla de Multiplicar";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(30, 377);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(193, 26);
            textBoxName.TabIndex = 5;
            textBoxName.Text = "By: Jean Paulo Puentes P";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelnumero;
        private Label labeltitle;
        private RichTextBox richTextBoxResultados;
        private Button buttonVer;
        private TextBox textBoxNum;
        private TextBox textBoxName;
        private NotifyIcon notifyIcon1;
    }
}
