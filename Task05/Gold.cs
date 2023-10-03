class Gold
{
    public string Name { get => "Gold"; }
    public int CashAmount { get; set; }

    public Gold(int CashAmount)
    {
        this.CashAmount = CashAmount;
    }
}