namespace CinemaKino
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
            button1 = new Button();
            button2 = new Button();
            btnJson = new Button();
            btnXml = new Button();
            btnTransferir = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(337, 167);
            button1.Name = "button1";
            button1.Size = new Size(113, 33);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(333, 233);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(117, 37);
            button2.TabIndex = 1;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnJson
            // 
            btnJson.Location = new Point(337, 83);
            btnJson.Margin = new Padding(4, 5, 4, 5);
            btnJson.Name = "btnJson";
            btnJson.Size = new Size(107, 38);
            btnJson.TabIndex = 2;
            btnJson.Text = "Json";
            btnJson.UseVisualStyleBackColor = true;
            btnJson.Click += btnJson_Click;
            // 
            // btnXml
            // 
            btnXml.Location = new Point(334, 41);
            btnXml.Name = "btnXml";
            btnXml.Size = new Size(112, 34);
            btnXml.TabIndex = 3;
            btnXml.Text = "Xml";
            btnXml.UseVisualStyleBackColor = true;
            btnXml.Click += btnXml_Click;
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(273, 302);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(245, 47);
            btnTransferir.TabIndex = 4;
            btnTransferir.Text = "Tranferir a SQL";
            btnTransferir.UseVisualStyleBackColor = true;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTransferir);
            Controls.Add(btnXml);
            Controls.Add(btnJson);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnJson;
        private Button btnXml;
        private Button btnTransferir;
    }
}
