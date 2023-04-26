partial class Program
{
  static void C04_BinaryWrite()
  {
    using (var fileStream = new FileStream("currentAccount.txt",FileMode.Create))
    using(var writer = new BinaryWriter(fileStream))  
    {
      writer.Write(123);
      writer.Write(456789);
      writer.Write(3456.09);
      writer.Write("Tiago Barbosa");
    }
  }
  
  static void C04_BinaryReader()
  {
    using (var fileStream = new FileStream("currentAccount.txt",FileMode.Open))
    using(var reader = new BinaryReader(fileStream))
    {
      var agency = reader.ReadInt32();
      var accountNumber = reader.ReadInt32();
      var balance = reader.ReadDouble();
      var holder = reader.ReadString();

      Console.WriteLine($"Agency: {agency}\n" +
                        $"Account number: {accountNumber}\n" +
                        $"Balance: {balance}\n" +
                        $"Holder: {holder}");
    }
  }
}