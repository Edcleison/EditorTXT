using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorTXT
{
    public static class Gerenciador
    {
        //Valores Padrão
        public static string DefautFolderPath => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";

        public static string DefautFileName => "arquivo";
        public static string DefautFileExt => ".txt";

        // Valores Atribuidos ao uso
        public static string FolderPath { get; set; } = DefautFolderPath;
        public static string FileName { get; set; } = DefautFileName;
        public static string FileExt { get; set; } = DefautFileExt;
        public static string FilePath => FolderPath + FileName + FileExt;

    }
}
