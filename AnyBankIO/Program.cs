partial class Program
{
  static void Main(string[] args)
  {
    var fileAddress = "contas.txt";

    using (var fileStream = new FileStream(fileAddress, FileMode.Open))
    {
      var reader = new StreamReader(fileStream);

      // var line = reader.ReadLine();
      // var text = reader.ReadToEnd();
      // var number = reader.Read();

      while (!reader.EndOfStream)
      {
        var line = reader.ReadLine();
        Console.WriteLine(line);
      }
    }
  }
}