namespace SwaggerClient
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
            this.cmdAllValues = new System.Windows.Forms.Button();
            this.cmdValue = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAllValues
            // 
            this.cmdAllValues.Location = new System.Drawing.Point(53, 66);
            this.cmdAllValues.Name = "cmdAllValues";
            this.cmdAllValues.Size = new System.Drawing.Size(75, 23);
            this.cmdAllValues.TabIndex = 0;
            this.cmdAllValues.Text = "All Values";
            this.cmdAllValues.UseVisualStyleBackColor = true;
            this.cmdAllValues.Click += new System.EventHandler(this.cmdAllValues_Click);
            // 
            // cmdValue
            // 
            this.cmdValue.Location = new System.Drawing.Point(343, 66);
            this.cmdValue.Name = "cmdValue";
            this.cmdValue.Size = new System.Drawing.Size(75, 23);
            this.cmdValue.TabIndex = 1;
            this.cmdValue.Text = "Single Value";
            this.cmdValue.UseVisualStyleBackColor = true;
            this.cmdValue.Click += new System.EventHandler(this.cmdValue_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(53, 235);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdate.TabIndex = 2;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 452);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdValue);
            this.Controls.Add(this.cmdAllValues);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAllValues;
        private System.Windows.Forms.Button cmdValue;
        private System.Windows.Forms.Button cmdUpdate;
    }
}

