using System.Text;

var fileAddress = "contas.txt";
var readedBytes = -1;
var fileStream = new FileStream(fileAddress, FileMode.Open);
var buffer = new byte[1024];


while (readedBytes != 0)
{
  readedBytes = fileStream.Read(buffer, 0, 1024);
  BufferWrite(buffer);
}

static void BufferWrite(byte[] buffer)
{
  var utf8 = new UTF8Encoding();
  var text = utf8.GetString(buffer);
  Console.Write(text);
}