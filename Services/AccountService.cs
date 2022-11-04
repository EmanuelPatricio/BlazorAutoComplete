using BlazorAutoComplete.Data;
using System.Text.RegularExpressions;

namespace BlazorAutoComplete.Services
{
  public class AccountService
  {
    private static Random random = new Random();
    public List<Account> GetAccounts()
    {
      var account = new List<Account>();

      for (int i = 0; i < 10; i++)
      {
        account.Add(new Account()
        {
          AccountId = Regex.Replace(new string(Enumerable.Repeat("0123456789", 15)
        .Select(s => s[random.Next(s.Length)]).ToArray()), @"^(...)(...)(...)(...)(...)$", "$1-$2-$3-$4-$5"),
          AccountAlias = new string(Enumerable.Repeat("0123456789", 6)
        .Select(s => s[random.Next(s.Length)]).ToArray())
        });
      }

      return account;
    }
  }
}
