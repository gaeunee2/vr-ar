using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject timeText;
    GameObject pointText;
    float time = 60.0f;
    int point = 0;
    GameObject generator;

    public void GetApple()
    {
        this.point += 100;
    }

    public void GetBomb()
    {
        this.point /= 2;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.timeText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");
        this.generator = GameObject.Find("ItemGenerator");
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;

        if(this.time < 0)
        {
            this.time = 0;
            this.generator.GetComponent<ItemGenerator>().setParameter(10000.0f, 0, 0);
        }
        else if(0 <= this.time && this.time < 5)
        {
            this.generator.GetComponent<ItemGenerator>().setParameter(0.9f, -0.04f, 3);
        }
        else if(5 <= this.time && this.time < 10)
        {
            this.generator.GetComponent<ItemGenerator>().setParameter(0.4f, -0.06f, 6);
        }
        else if(10 <= this.time && this.time < 20)
        {
            this.generator.GetComponent<ItemGenerator>().setParameter(0.7f, -0.04f, 4);
        }
        else if(20 <= this.time && this.time < 30)
        {
            this.generator.GetComponent<ItemGenerator>().setParameter(1.0f, -0.03f, 2);
        }

        this.timeText.GetComponent<TextMeshProUGUI>().text = this.time.ToString("F1");
        this.pointText.GetComponent<TextMeshProUGUI>().text = this.point.ToString() + " point";
    }
}
