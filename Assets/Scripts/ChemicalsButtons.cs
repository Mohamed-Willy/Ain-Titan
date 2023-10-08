using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChemicalsButtons : MonoBehaviour
{
    public void br()
    {
        if(Inventory.br2 >= 3)
        {
            Inventory.br2 -= 3;
            Inventory.chbr3 += 3;
        }
    }
    public void mg()
    {
        if (Inventory.mg >= 1)
        {
            Inventory.mg -= 1;
            Inventory.mgh2 += 1;
        }
    }
    public void s()
    {
        if (Inventory.s >= 1)
        {
            Inventory.s -= 1;
            Inventory.h2s += 1;
        }
    }
}
