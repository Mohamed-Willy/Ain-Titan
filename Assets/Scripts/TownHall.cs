using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownHall : MonoBehaviour
{
    public GameObject panelss;
    private void OnMouseDown()
    {
        panelss.SetActive(true);
    }
}
