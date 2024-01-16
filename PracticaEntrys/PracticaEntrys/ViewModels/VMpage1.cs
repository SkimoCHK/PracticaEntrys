using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PracticaEntrys.ViewModels
{
    public class VMpage1 : BaseViewModel
    {
        public VMpage1(INavigation navigation ) 
        {
         Navigation = navigation;
        }

        public class ChangeColor : TriggerAction<Button>
        {
            protected override void Invoke(Button btn)
            {
                btn.BackgroundColor = Color.DarkOrange;
                btn.Text = "Here we go!!!";
            }
        }

    }

}
