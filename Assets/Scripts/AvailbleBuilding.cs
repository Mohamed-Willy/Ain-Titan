using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvailbleBuilding : MonoBehaviour
{
    public static bool chemicals_bl, electric_bl, o2_bl, fe_bl, h2o_bl;
    public static bool br2_bl, metal_bl, mg_bl, s_bl;
    [SerializeField] private Button chemicals, electric, o2, fe, h2o;
    [SerializeField] private Button br2, metal, mg, s;
    private void Update()
    {
        if(Inventory.electricity > 5)
        {
            br2.image.color = Color.green;
            metal.image.color = Color.green;
            mg.image.color = Color.green;
            s.image.color = Color.green;
            br2_bl = true;
            metal_bl = true;
            mg_bl = true;
            s_bl = true;
        }
        else
        {
            br2.image.color = Color.red;
            metal.image.color = Color.red;
            mg.image.color = Color.red;
            s.image.color = Color.red;
            br2_bl = false;
            metal_bl = false;
            mg_bl = false;
            s_bl = false;
        }
        if (Inventory.metal >= 50)
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
