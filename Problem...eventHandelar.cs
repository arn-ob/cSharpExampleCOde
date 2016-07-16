using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;


/// Problem This code i cant solve this 

namespace learnFormEvent
{
    public class eventarg{
    
        public eventarg(string s){text = s;}
        public string text {get; private set;}
    }
    
    
    class eventHandelar
    {
        public void Main()
        {
            public delegate void eventarga(object sender,EventArgs e);

                public event eventarga even;
 
            protected virtual void RaiseS(){
                if(even != null)
                    even(this, new eventarg("hello"));
            }

            
        }



    }
}
