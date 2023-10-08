using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvailbleChemicals : MonoBehaviour
{
    [SerializeField] private Button br, mg, s;
    // Update is called once per frame
    void Update()
    {
        if (Inventory.br2 >= 3)
        {
            br.image.color = Color.green;
        }
        else
        {
            br.image.color = Color.red;
        }
        if (Inventory.mg >= 1)
        {
            mg.image.color = Color.green;
        }
        else
        {
            mg.image.color = Color.red;
        }
        if (Inventory.s >= 1)
        {
            s.image.color = Color.green;
        }
        else
        {
            s.image.color = Color.red;
        }
    }
}
