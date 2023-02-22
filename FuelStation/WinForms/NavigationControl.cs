using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    public class NavigationControl
    {
        List<UserControl> userControls= new List<UserControl>();
        Panel panel;        

        public NavigationControl(List<UserControl> userControls, Panel panel)
        {
            this.userControls = userControls;
            this.panel = panel;
            AddUserControlls();
        }

        private void AddUserControlls()
        {
            for(int i=0; i<userControls.Count(); i++)
            {
                userControls[i].Dock = DockStyle.Fill;
                panel.Controls.Add(userControls[i]);
            }
        }

        public void Display(int index)
        {
            if (index < userControls.Count())
            {
                userControls[index].BringToFront();
            }
        }

    }
}
