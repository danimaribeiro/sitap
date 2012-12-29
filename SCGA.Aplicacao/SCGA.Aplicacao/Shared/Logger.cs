using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCGA.Aplicacao.Shared
{
    public class Logger
    {
        private static Logger _log;

        private Logger()
        {
        }

        public static Logger GetInstance()
        {
            if (_log == null)
                _log = new Logger();
            return _log;
        }


        public void Log(string mensagem)
        {
            GravaLogEmTxt(mensagem);
        }

        public void Log(Exception ex)
        {
            GravaLogEmTxt(ex.ToString());
        }

        private void GravaLogEmTxt(string mensagem)
        {
            try
            {
                string pasta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");

                // se não existe a pasta cria a ela no startap da aplicação
                if (!System.IO.Directory.Exists(pasta))
                    System.IO.Directory.CreateDirectory(pasta);

                // recebe a data atual para gravar o log
                System.DateTime dt = DateTime.Now;
                string file = dt.Day + "-" + dt.Month + "-" + dt.Year + ".txt";

                pasta = System.IO.Path.Combine(pasta, file);

                System.IO.StreamWriter strw = new System.IO.StreamWriter(pasta, true);
                try
                {
                    strw.WriteLine(DateTime.Now.ToShortTimeString());
                    strw.WriteLine(mensagem);
                    strw.WriteLine();
                }
                catch
                {
                    //Não deve deixar lançar erro ao gravar log.
                }
                finally
                {
                    strw.Close();
                }
            }
            catch
            {
                //Não deve deixar lançar erro ao gravar log.
            }
        }
    }
}
