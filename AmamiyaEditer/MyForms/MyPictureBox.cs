using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmamiyaEditer.MyForms
{
    class MyPictureBox : PictureBox
    {
        protected override void OnCreateControl()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(this.ClientRectangle);
            Region region = new Region(gp);
            this.Region = region;
            gp.Dispose();
            region.Dispose();
            base.OnCreateControl();
        }
    }
}
