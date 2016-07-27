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
               
                     Process p = new Process();
                     p.EnableRaisingEvents = false;
                     p.StartInfo.FileName = "C:\\WINDOWS\\system32\\cmd.exe";
                     p.StartInfo.Arguments = " /c shutdown /s";         
                     p.StartInfo.CreateNoWindow = true;
                     p.Start();
                     break;
                }
            }
       
    }

    public void Shut_DownTiempo(int tiempo)
    {

        while (true)
        {
            if (date1.ToLongTimeString() != DateTime.Now.ToLongTimeString())
            {
                
                Process p = new Process();
                p.EnableRaisingEvents = false;
                p.StartInfo.FileName = "C:\\WINDOWS\\system32\\cmd.exe";
                p.StartInfo.Arguments = " /c shutdown -s -t "+ tiempo;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                break;
            }
        }

    }


        /*
         * shutdown -i = Muestra las opciones a realizar pero graficamente. 
shutdown -l = Solo cierra la sesion en la que se ejecuto el comando. 
shutdown -s = Apaga el equipo. 
shutdown -r = Apaga y reinicia el equipo. 
shutdown -g = Cierra y reinicia el equipo, pero al iniciar reinicia las aplicaciones registradas. 
shutdown -a = Anula el apagado del sistema, pero este comando solo se puede ejecutar mientras esperamos el tiempo que se determino de espera. 
shutdown -p = Apaga el equipo pero sin avisar ni con un tiempo de espera. 
shutdown -h = Este comando hiberna al equipo. 
shutdown -m = Especifica a que equipo se quiere ejecutar este comando (no sirve el comando -l) 
shutdown -t = Especifica el tiempo de espera para que se apague. 
shutdown -c = Es un comentario acerca del reinicio o apagado (shutdown -c "comentario). 
shutdown -f = Fuerza a las aplicaciones a cerrarse, sin avisarle al usuario antes. */

    public void Reset()
    {

        while (true)
        {
            if (date1.ToLongTimeString() != DateTime.Now.ToLongTimeString())
            {

                Process p = new Process();
                p.EnableRaisingEvents = false;
                p.StartInfo.FileName = "C:\\WINDOWS\\system32\\cmd.exe";
                p.StartInfo.Arguments = " /c shutdown /r";
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                break;
            }
        }

    }
    }
}
