partial class Program
{
  static void Main(string[] args)
  {
    // Console.WriteLine("Enter your name: ");
    // var name = Console.ReadLine();

    var lines = File.ReadAllLines("contas.txt");
    Console.WriteLine($"Total lines in the file contas.txt: {lines.Length}");

    // foreach (var line in lines)
    // {
    //   Console.WriteLine(line);
    // }

    var fileBytes = File.ReadAllBytes("contas.txt");
    Console.WriteLine($"Total bytes in the file contas.txt: {fileBytes.Length} bytes");
    
    File.WriteAllText("writingFileWithClassFile.txt","Testing File.WriteAllText");
    // C05_UsingConsoleStream();
  }

  
}