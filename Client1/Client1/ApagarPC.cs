using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using System.Diagnostics;

namespace Client1
{
    class ApagarPC
    {
        string argumento = null;
        DateTime date1 = DateTime.Now;
    public ApagarPC()
    {
       
    }

    public void Shut_Down()
    {
        
            while (true)
            {                    
                if(date1.ToLongTimeString() != DateTime.Now.ToLongTimeString())
                {
                   /* Process proceso = new Process();
                    proceso.StartInfo.UseShellExecute = false;
                    proceso.StartInfo.RedirectStandardOutput = true;
                     // proceso.StartInfo.FileName = "C:\\WINDOWS\\system32\\cmd.exe";
                   proceso.StartInfo.Arguments = " /c shutdown /H";
                   // proceso.StartInfo.FileName = "C:\\WINDOWS\\system32\\shutdown.exe";
                    //proceso.StartInfo.FileName = "shutdown.exe";
                   proceso.StartInfo.Arguments = this.argumento;
                    proceso.Start();*/

                     Process p = new Process();

            p.EnableRaisingEvents = false;
            p.StartInfo.FileName = "C:\\WINDOWS\\system32\\cmd.exe";
            p.StartInfo.Arguments = " /c shutdown /H";
           
            p.StartInfo.CreateNoWindow = true;
            p.Start();
                    break;
                }
            }
       
    }
    }
}
