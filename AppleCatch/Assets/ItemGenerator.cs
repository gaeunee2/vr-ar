using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;
    float span = 1.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;

            int itemType = Random.Range(0, 2);

            int px = Random.Range(-1, 1);
            int pz = Random.Range(-1, 1);
            Vector3 randomPosition = new Vector3(px, 3, pz);

            if (itemType == 0)
            {
                GameObject apple = Instantiate(applePrefab);
                apple.transform.position = randomPosition;
            }
            else
            {
                GameObject bomb = Instantiate(bombPrefab);
                bomb.transform.position = randomPosition;
            }
        }
    }
}
