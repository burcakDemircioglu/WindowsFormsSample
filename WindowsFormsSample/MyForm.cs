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
        private Button showMessageButton;

        public MyForm() : base()
        {
            this.Text = "My Form";

            messageTextBox = new TextBox();
            messageTextBox.Left = 25;
            messageTextBox.Top = 25;
            messageTextBox.Width = 200;
            this.Controls.Add(messageTextBox);

            showMessageButton = new Button();
            showMessageButton.Left = 25;
            showMessageButton.Top = 75;
            showMessageButton.Width = 200;
            showMessageButton.Text = "Show Message";
            showMessageButton.Click += ClickHandler;
            this.Controls.Add(showMessageButton);

            messageLabel = new Label();
            messageLabel.Left = 25;
            messageLabel.Top = 125;
            messageLabel.Width = 200;
            messageLabel.Text = "[Label]";
            this.Controls.Add(messageLabel);
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            messageLabel.Text = messageTextBox.Text;
        }
    }
}
