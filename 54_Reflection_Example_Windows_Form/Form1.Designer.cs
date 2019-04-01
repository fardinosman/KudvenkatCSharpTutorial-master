namespace _54_Reflection_Example_Windows_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TypeName = new System.Windows.Forms.TextBox();
            this.btn_TypeInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_Methods = new System.Windows.Forms.ListBox();
            this.listBox_properties = new System.Windows.Forms.ListBox();
            this.listBox_Constructors = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name";
            // 
            // textBox_TypeName
            // 
            this.textBox_TypeName.Location = new System.Drawing.Point(141, 23);
            this.textBox_TypeName.Name = "textBox_TypeName";
            this.textBox_TypeName.Size = new System.Drawing.Size(254, 20);
            this.textBox_TypeName.TabIndex = 1;
            // 
            // btn_TypeInfo
            // 
            this.btn_TypeInfo.Location = new System.Drawing.Point(447, 23);
            this.btn_TypeInfo.Name = "btn_TypeInfo";
            this.btn_TypeInfo.Size = new System.Drawing.Size(243, 23);
            this.btn_TypeInfo.TabIndex = 2;
            this.btn_TypeInfo.Text = "Discover Type Information";
            this.btn_TypeInfo.UseVisualStyleBackColor = true;
            this.btn_TypeInfo.Click += new System.EventHandler(this.btn_TypeInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Methods";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Properties";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Constructors";
            // 
            // listBox_Methods
            // 
            this.listBox_Methods.FormattingEnabled = true;
            this.listBox_Methods.Location = new System.Drawing.Point(12, 138);
            this.listBox_Methods.Name = "listBox_Methods";
            this.listBox_Methods.Size = new System.Drawing.Size(234, 290);
            this.listBox_Methods.TabIndex = 6;
            // 
            // listBox_properties
            // 
            this.listBox_properties.FormattingEnabled = true;
            this.listBox_properties.Location = new System.Drawing.Point(252, 138);
            this.listBox_properties.Name = "listBox_properties";
            this.listBox_properties.Size = new System.Drawing.Size(240, 290);
            this.listBox_properties.TabIndex = 7;
            // 
            // listBox_Constructors
            // 
            this.listBox_Constructors.FormattingEnabled = true;
            this.listBox_Constructors.Location = new System.Drawing.Point(498, 138);
            this.listBox_Constructors.Name = "listBox_Constructors";
            this.listBox_Constructors.Size = new System.Drawing.Size(259, 290);
            this.listBox_Constructors.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear ListBoxses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_Constructors);
            this.Controls.Add(this.listBox_properties);
            this.Controls.Add(this.listBox_Methods);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_TypeInfo);
            this.Controls.Add(this.textBox_TypeName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TypeName;
        private System.Windows.Forms.Button btn_TypeInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_Methods;
        private System.Windows.Forms.ListBox listBox_properties;
        private System.Windows.Forms.ListBox listBox_Constructors;
        private System.Windows.Forms.Button button1;
    }
}

