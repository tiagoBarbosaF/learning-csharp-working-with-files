using AnyBankIO;

partial class Program
{
  static void C02_UsingStreamReader()
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
        var account = ConvertStringForCurrentAccount(line!);
        Console.WriteLine();
        Console.WriteLine(line);
        Console.WriteLine(account.ToString());
      }
    }
  }
  
  static CurrentAccount ConvertStringForCurrentAccount(string line)
  {
    var fields = line.Split(',');

    var agency = int.Parse(fields[0]);
    var number = int.Parse(fields[1]);
    var balance = double.Parse(fields[2]);

    var holder = new Client();
    holder.Name = fields[3];
    
    var result = new CurrentAccount(agency, number);
    result.Deposit(balance);
    result.Holder = holder;

    return result;
  }
}