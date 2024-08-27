using UnityEngine;

public class Bank 
{
    public static Bank instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new Bank();
            }
            return _instance;
        }
    }

    private static Bank _instance;
    public int coin { get; private set; }

    public void AddCoin(int Coin)
    {
        coin += Coin;
    }

    public void Debug()
    {
        UnityEngine.Debug.Log("Bank");
    }

    public void StartDebug()
    {
        UnityEngine.Debug.Log("Bank started");
    }
}
