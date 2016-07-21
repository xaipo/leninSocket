using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client1
{
    class FormControl_Single
    {
        private static volatile FormControl_Single instance = null;
        private static readonly object padlock = new object();
        private FormControl_Single()
        {

            ControlSecion frmControl = new ControlSecion();
            frmControl.Show();
           
        }

        public static FormControl_Single getInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                            instance = new FormControl_Single();
                    }
                }

                return instance;
            }
        }

    }
}
