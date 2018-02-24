using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace SqLiteTesteDefi1 {
    class Program {        

        public static string conexao = "Data Source=banco.db";
        public static string nomebanco = "banco.db";

        

        static void Main(string[] args) {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaInicial());


            
        }
    }
}
