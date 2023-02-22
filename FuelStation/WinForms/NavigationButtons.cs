using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    public class NavigationButtons
    {
        List<Button> buttons;
        Color defaultColor;
        Color selectColor;

        public NavigationButtons(List<Button> buttons, Color defaultColor, Color selectColor)
        {
            this.buttons = buttons;
            this.defaultColor = defaultColor;
            this.selectColor = selectColor;
            SetButtonColor();           
        }

        private void SetButtonColor()
        {
            foreach(Button button in buttons)
            {
                button.BackColor= defaultColor;
            }
        }

        public void Highlight(Button selectedButton)
        {
            foreach(Button button in buttons)
            {
                if(button == selectedButton)
                {
                    button.BackColor = selectColor;
                }
                else
                {
                    button.BackColor = defaultColor;
                }
            }
        }

    }

}
