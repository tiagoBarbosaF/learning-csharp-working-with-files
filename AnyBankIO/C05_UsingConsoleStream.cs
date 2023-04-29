partial class Program
{
  static void C05_UsingConsoleStream()
  {
    using (var streamEntry = Console.OpenStandardInput())
    using (var fileStream = new FileStream("entryConsole.txt", FileMode.Create))
    {
      var buffer = new byte[1024];
      while (true)
      {
        var readedBytes = streamEntry.Read(buffer, 0, 1024);
        fileStream.Write(buffer, 0, readedBytes);
        fileStream.Flush();
        Console.WriteLine($"Read bytes in console: {readedBytes}");
      }
    }
  }
}