using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ObjectClicked : MonoBehaviour
{
    public static float timer = 100;
    public GameObject g, b1, b2, b3, b4, b6;
    public int state = 0;
    public GameObject panel, metal_panel, chemical_panel;
    private void OnMouseDown()
    {
        if (panel.activeSelf && metal_panel && chemical_panel)
        {
            return;
        }
        // Ground
        if (state == 0) 
        {
            panel.SetActive(true);
            BuildingButtons.g = g;
            BuildingButtons.b1 = b1;
            BuildingButtons.b2 = b2;
            BuildingButtons.b3 = b3;
            BuildingButtons.b4 = b4;
            BuildingButtons.b6 = b6;
            BuildingButtons.obj = this;
            BuildingButtons.panel = panel;
        }
        // Metal
        else if (state == 2)
        {
            metal_panel.SetActive(true);
        }
        // Chemicals
        else if (state == 4) 
        {
            chemical_panel.SetActive(true);
        }
    }
}
