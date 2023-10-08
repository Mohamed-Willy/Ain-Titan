using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalButtons : MonoBehaviour
{
    public void metal()
    {
        if (AvailbleBuilding.metal_bl)
        {
            Inventory.electricity -= 5;
            Inventory.metal++;
        }
    }
    public void br2()
    {
        if (AvailbleBuilding.br2_bl)
        {
            Inventory.electricity -= 5;
            Inventory.br2++;
        }
    }
    public void mg()
    {
        if (AvailbleBuilding.mg_bl)
        {
            Inventory.electricity -= 5;
            Inventory.mg++;
        }
    }
    public void s()
    {
        if (AvailbleBuilding.s_bl)
        {
            Inventory.electricity -= 5;
            Inventory.s+=10;
        }
    }
    public void back(GameObject panel)
    {
        panel.SetActive(false);
        ObjectClicked.timer = 0;
    }
}
