namespace pract
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.windowinput = new System.Windows.Forms.TextBox();
            this.windowoutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encoding = new System.Windows.Forms.Button();
            this.decoding = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // windowinput
            // 
            this.windowinput.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.windowinput, "windowinput");
            this.windowinput.Name = "windowinput";
            this.windowinput.TextChanged += new System.EventHandler(this.write);
            // 
            // windowoutput
            // 
            this.windowoutput.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.windowoutput, "windowoutput");
            this.windowoutput.Name = "windowoutput";
            this.windowoutput.ReadOnly = true;
            this.windowoutput.TextChanged += new System.EventHandler(this.read);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.choose);
            // 
            // encoding
            // 
            this.encoding.BackColor = System.Drawing.Color.PaleGoldenrod;
            resources.ApplyResources(this.encoding, "encoding");
            this.encoding.Name = "encoding";
            this.encoding.UseVisualStyleBackColor = false;
            this.encoding.Click += new System.EventHandler(this.encodingbutton);
            // 
            // decoding
            // 
            this.decoding.BackColor = System.Drawing.Color.PaleGoldenrod;
            resources.ApplyResources(this.decoding, "decoding");
            this.decoding.Name = "decoding";
            this.decoding.UseVisualStyleBackColor = false;
            this.decoding.Click += new System.EventHandler(this.decodingbutton);
            // 
            // x
            // 
            this.x.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.x, "x");
            this.x.Name = "x";
            this.x.TextChanged += new System.EventHandler(this.writex);
            // 
            // y
            // 
            this.y.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.y, "y");
            this.y.Name = "y";
            this.y.TextChanged += new System.EventHandler(this.writey);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.windowinput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.decoding);
            this.Controls.Add(this.encoding);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windowoutput);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox windowinput;
        private TextBox windowoutput;
        private Label label1;
        private Label label2;
        private Button encoding;
        private Button decoding;
        private TextBox x;
        private TextBox y;
        private Label label3;
        private Label label4;
    }
}