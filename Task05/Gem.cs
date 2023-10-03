class Gem
{
    public string Name { get; }
    public int CashAmount { get; set; }

    public Gem(string Name, int CashAmount)
    {
        this.Name = Name;
        this.CashAmount = CashAmount;
    }
}