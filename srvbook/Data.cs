namespace srvbook
{
    public class Data
    {
        public static List<string> Readers { get; set; } = new List<string>()
        {
            "Арбузов Н.В.",
            "Вылегжанина О.Ю.",
            "Иванов П.Р.",
            "Петров С.Е.",
            "Сидоров А.И"
        };

        public static List<string> Books { get; set; } = new List<string>()
     {
       "Достоевский \"Идиот\"",
       "Куприн \"Сборник рассказов\"",
       "Лермонтов \"Мцыри\"",
       "Толстой \"Война и мир\""
     };

        public Dictionary<string, List<string>> Info { get; set; } = new Dictionary<string, List<string>>();

        public List<string> GetBooks()
        {
            return Books;
        }
        public List<string> GetReaders()
        {
            return Readers;
        }
     public List<string> GetbooksGivenReader(string nameReader)
        {
          var results = new List<string>();
            var isReader = Info.ContainsKey(nameReader);
            if (isReader) results = Info[nameReader];
            return results;
        }

    
    
    
    }
}
