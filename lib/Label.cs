using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class Label : System.Windows.Forms.Label
    {
        public Label()
        {
            this.Font = new Font(Font, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.AutoSize = true;
            this.Anchor = AnchorStyles.None;
        }
    }
}