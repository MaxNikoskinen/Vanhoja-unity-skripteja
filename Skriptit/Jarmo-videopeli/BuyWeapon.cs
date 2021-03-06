using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyWeapon : MonoBehaviour
{
    private bool isBought;

    public void BuyWeaponWeapon(int cost)
    {
        if(!isBought)
        {
            //isBought todeksi jotta samaa ei voi ostaa kaksi kertaa
            isBought = true;

            //Hakee rahamäärän
            int moneyGet = -1;
            moneyGet = GameManager.Instance.GetMoney();

            //Miinustaa rahamäärästä hinnan
            if(moneyGet >= cost)
            {
                moneyGet -= cost;
            }
            
            //Päivittää rahamäärän gamemanageriin
            GameManager.Instance.UpdateMoneyAmount(moneyGet);
        }
    }
}
