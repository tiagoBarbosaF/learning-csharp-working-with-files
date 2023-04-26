using System.Text;

partial class Program
{
  static void C03_CreatingFile()
  {
    var addressNewFile = "exportedAccounts.csv";

    using (var fileStream = new FileStream(addressNewFile, FileMode.Create))
    {
      var stringAccount = "123,7654,15430.50,Tiago Barbosa";
      var encoding = Encoding.UTF8;
      var bytes = encoding.GetBytes(stringAccount);

      fileStream.Write(bytes, 0, bytes.Length);
    }
  }

  static void C03_CreatingFileWithStreamWriter()
  {
    var addressNewFile = "exportedAccounts.csv";

    using (var fileStream = new FileStream(addressNewFile, FileMode.Create))
    using (var writer = new StreamWriter(fileStream))
    {
      writer.Write("987,3495,503.60,John Cena");
    }
  }

  static void C03_WriteTest()
  {
    var addressNewFile = "test.txt";

    using (var fileStream = new FileStream(addressNewFile, FileMode.Create))
    using (var writer = new StreamWriter(fileStream))
    {
      for (int i = 0; i < 100000; i++)
      {
        writer.WriteLine($"Line {i}");
        writer.Flush();
        Console.WriteLine($"Line {i} has writing successfully. Enter any key for continue...");
        Console.ReadLine();
      }
    }
  }
}