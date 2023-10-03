class Cash
{
    public string Name { get; }
    public string Currency { get; }
    public int CashAmount { get; set; }
    public Cash(string Name, string Currency ,int CashAmount)
    {
        this.Name = Name;
        this.CashAmount = CashAmount;
    } 
}