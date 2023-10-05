using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvailbleBuilding : MonoBehaviour
{
    public static bool chemicals_bl, electric_bl, o2_bl, fe_bl, h2o_bl;
    [SerializeField] private Button chemicals, electric, o2, fe, h2o;
    private void Update()
    {
        if(Inventory.metal >= 50)
        {
            chemicals.image.color = Color.green;
            chemicals_bl = true;
        }
        else
        {
            chemicals.image.color = Color.red;
            chemicals_bl = false;
        }
        if (Inventory.metal >= 50 && Inventory.chbr3 >= 10)
        {
            h2o.image.color = Color.green;
            h2o_bl = true;
        }
        else
        {
            h2o.image.color = Color.red;
            h2o_bl = false;
        }
        if (Inventory.metal >= 20 && Inventory.mgh2 >= 10)
        {
            fe.image.color = Color.green;
            fe_bl = true;
        }
        else
        {
            fe.image.color = Color.red;
            fe_bl = false;
        }
        if (Inventory.metal >= 10 && Inventory.h2s >= 10)
        {
            electric.image.color = Color.green;
            electric_bl = true;
        }
        else
        {
            electric.image.color = Color.red;
            electric_bl = false;
        }
        if (Inventory.metal >= 100 && Inventory.chbr3 >= 5 && Inventory.mgh2 >= 20)
        {
            o2.image.color = Color.green;
            o2_bl = true;
        }
        else
        {
            o2.image.color = Color.red;
            o2_bl = false;
        }
    }
}
