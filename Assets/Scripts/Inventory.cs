using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static int chbr3, mgh2, h2s, h2o, metal, electricity, o2, br2, mg, s;
    [SerializeField] private Text chbr3_t, mgh2_t, h2s_t, metal_t, br2_t, mg_t, s_t;
    // Start is called before the first frame update
    void Start()
    {
        metal = 50;
        h2s = 50;
        mgh2 = 20;
        o2 = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        chbr3_t.text = chbr3.ToString();
        mgh2_t.text = mgh2.ToString();
        h2s_t.text = h2s.ToString();
        metal_t.text = metal.ToString();
        br2_t.text = br2.ToString();
        mg_t.text = mg.ToString();
        s_t.text = s.ToString();
    }
}
