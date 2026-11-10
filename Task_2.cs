using System;

//wallet 1
Wallet wallet = new();
wallet.AddMoney(50000);
Console.WriteLine(wallet.SpendMoney(12000));
Console.WriteLine(wallet.SpendMoney(40000));
Console.WriteLine(wallet.GetBalance());

//wallet2
Wallet wallet2 = new();
Console.WriteLine(wallet2.GetBalance());
public class Wallet
{
    //field
    public int Balance = 0;

    //methods
    public void AddMoney(int amount)
    {
        if (amount > 0)
        {
            this.Balance += amount;
        }
    }
    public bool SpendMoney(int amount)
    {
        if (amount > 0 && this.Balance >= amount)
        {
            this.Balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
    public int GetBalance()
    {
        return this.Balance;
    }
}