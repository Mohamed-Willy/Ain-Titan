using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicked : MonoBehaviour
{
    public GameObject g, b1, b2, b3, b4, b6;
    public int state = 0;
    public GameObject panel;
    private void OnMouseDown()
    {
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
    }
}
