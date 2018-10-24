namespace CasimirJustin_Assignment1
{
    partial class UserInput
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
            this.textItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHAVE = new System.Windows.Forms.Button();
            this.buttonNEED = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textItem
            // 
            this.textItem.Location = new System.Drawing.Point(130, 65);
            this.textItem.Name = "textItem";
            this.textItem.Size = new System.Drawing.Size(100, 20);
            this.textItem.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item:";
            // 
            // buttonHAVE
            // 
            this.buttonHAVE.Location = new System.Drawing.Point(58, 109);
            this.buttonHAVE.Name = "buttonHAVE";
            this.buttonHAVE.Size = new System.Drawing.Size(75, 23);
            this.buttonHAVE.TabIndex = 7;
            this.buttonHAVE.Text = "HAVE";
            this.buttonHAVE.UseVisualStyleBackColor = true;
            this.buttonHAVE.Click += new System.EventHandler(this.buttonHAVE_Click);
            // 
            // buttonNEED
            // 
            this.buttonNEED.Location = new System.Drawing.Point(228, 109);
            this.buttonNEED.Name = "buttonNEED";
            this.buttonNEED.Size = new System.Drawing.Size(75, 23);
            this.buttonNEED.TabIndex = 8;
            this.buttonNEED.Text = "NEED";
            this.buttonNEED.UseVisualStyleBackColor = true;
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 144);
            this.Controls.Add(this.buttonNEED);
            this.Controls.Add(this.buttonHAVE);
            this.Controls.Add(this.textItem);
            this.Controls.Add(this.label1);
            this.Name = "UserInput";
            this.Text = "UserInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHAVE;
        private System.Windows.Forms.Button buttonNEED;
    }
}