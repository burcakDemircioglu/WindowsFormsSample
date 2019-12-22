using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCSharp
{
    public class MyForm : Form
    {
        private TextBox messageTextBox;
        private Label messageLabel;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Label label1;
        private Button showMessageButton;

        public MyForm() : base()
        {


            InitializeComponent();
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            messageLabel.Text = messageTextBox.Text;
        }

        private void InitializeComponent()
        {
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.showMessageButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(25, 25);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(200, 20);
            this.messageTextBox.TabIndex = 0;
            // 
            // showMessageButton
            // 
            this.showMessageButton.Location = new System.Drawing.Point(25, 75);
            this.showMessageButton.Name = "showMessageButton";
            this.showMessageButton.Size = new System.Drawing.Size(200, 23);
            this.showMessageButton.TabIndex = 1;
            this.showMessageButton.Text = "Show Message";
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(25, 125);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(200, 23);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "[Label]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(266, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(266, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // MyForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.showMessageButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.button1);
            this.Name = "MyForm";
            this.Text = "My Form";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Oranges");
            listBox1.Items.Add("Grapes");
            listBox1.Items.Add("Bananas");
            listBox1.Items.Add("Peaches");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = listBox1.Text;
        }
    }
}
