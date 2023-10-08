using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private float timer = 0;
    public static int electric_factories = 0;
    public static int h2o_factories = 0;
    public static int o2_factories = 0;
    public static int chbr3, mgh2, h2s, h2o, metal, electricity, o2, br2, mg, s;
    [SerializeField] private Text chbr3_t, mgh2_t, h2s_t, metal_t, br2_t, mg_t, s_t, o2_t, h2o_t, e_t;
    // Start is called before the first frame update
    void Start()
    {
        metal = 200;
        h2s = 200;
        mgh2 = 200;
        o2 = 999;
        chbr3 = 100;
        h2o= 100; 
        electricity = 100;
        br2 = 100;
        mg = 100;
        s = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(o2 > 999)
        {
            SceneManager.LoadScene("Win");
        }
        if (o2 < 0)
        {
            SceneManager.LoadScene("Lose");
        }
        ObjectClicked.timer += Time.deltaTime;
        timer += Time.deltaTime;
        if(timer > 1)
        {
            electricity += electric_factories;
            if(h2o_factories <= electricity)
            {
                h2o += h2o_factories;
                electricity -= h2o_factories;
            }
            timer = 0;
            o2-=1;
            if(electricity >= 1 && h2o >= 2 && o2_factories == 1)
            {
                o2 += 1;
                electricity -= 1;
                h2o -= 2;
            }
            else if (electricity >= 2 && o2_factories >= 2 && h2o >= 4)
            {
                o2 += 2;
                electricity -= 2;
                h2o -= 4;
            }
        }
        chbr3_t.text = chbr3.ToString();
        mgh2_t.text = mgh2.ToString();
        h2s_t.text = h2s.ToString();
        metal_t.text = metal.ToString();
        br2_t.text = br2.ToString();
        mg_t.text = mg.ToString();
        s_t.text = s.ToString();
        o2_t.text = o2.ToString();
        h2o_t.text = h2o.ToString();
        e_t.text = electricity.ToString();
    }
}
