using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingButtons : MonoBehaviour
{
    public static GameObject g, b1, b2, b3, b4, b6, panel;
    public static ObjectClicked obj;
    public void b_chem()
    {
        if(AvailbleBuilding.chemicals_bl == true)
        {
            g.SetActive(false);
            b1.SetActive(true);
            b2.SetActive(false);
            b3.SetActive(false);
            b4.SetActive(false);
            b6.SetActive(false);
            panel.SetActive(false);
            obj.state = 4;
            Inventory.metal -= 50;
        }
    }
    public void b_o2()
    {
        if (AvailbleBuilding.o2_bl == true)
        {
            g.SetActive(false);
            b1.SetActive(false);
            b2.SetActive(false);
            b3.SetActive(false);
            b4.SetActive(true);
            b6.SetActive(false);
            panel.SetActive(false);
            obj.state = 5;
            Inventory.metal -= 100;
            Inventory.chbr3 -= 5;
            Inventory.mgh2 -= 20;
        }
    }
    public void b_e()
    {
        if (AvailbleBuilding.electric_bl == true)
        {
            g.SetActive(false);
            b1.SetActive(false);
            b2.SetActive(false);
            b3.SetActive(true);
            b4.SetActive(false);
            b6.SetActive(false);
            panel.SetActive(false);
            obj.state = 1;
            Inventory.metal -= 10;
            Inventory.h2s -= 10;
        }
    }
    public void b_fe()
    {
        if (AvailbleBuilding.fe_bl == true)
        {
            g.SetActive(false);
            b1.SetActive(false);
            b2.SetActive(true);
            b3.SetActive(false);
            b4.SetActive(false);
            b6.SetActive(false);
            panel.SetActive(false);
            obj.state = 2;
            Inventory.metal -= 20;
            Inventory.mgh2 -= 10;
        }
    }
    public void b_h2o()
    {
        if (AvailbleBuilding.h2o_bl == true)
        {
            g.SetActive(false);
            b1.SetActive(false);
            b2.SetActive(false);
            b3.SetActive(false);
            b4.SetActive(false);
            b6.SetActive(true);
            panel.SetActive(false);
            obj.state = 3;
            Inventory.metal -= 50;
            Inventory.chbr3 -= 10;
        }
    }

}
