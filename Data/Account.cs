namespace BlazorAutoComplete.Data
{
  public class Account
  {
    public string AccountId { get; set; }
    public string AccountAlias { get; set; }
    public string IdWithAlias => $"{this.AccountId}/{this.AccountAlias}";
  }
}
