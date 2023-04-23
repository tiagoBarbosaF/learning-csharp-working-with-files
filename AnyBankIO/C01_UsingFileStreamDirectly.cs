using System.Text;

partial class Program
{
  static void C01_UsingFileStreamDirectly()
  {
    const string fileAddress = "contas.txt";

    using (var fileStream = new FileStream(fileAddress, FileMode.Open))
    {
      var readedBytes = -1;
      var buffer = new byte[1024];

      while (readedBytes != 0)
      {
        readedBytes = fileStream.Read(buffer, 0, 1024);
        BufferWrite(buffer, readedBytes);
      }

      fileStream.Close();
    }

    static void BufferWrite(byte[] buffer, int readedBytes)
    {
      var utf8 = new UTF8Encoding();
      var text = utf8.GetString(buffer, 0, readedBytes);
      Console.Write(text);
    }
  }
}