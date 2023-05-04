using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishspawn : MonoBehaviour
{
    public float spawntime;
    private float times;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        times += Time.deltaTime;
        if(times > spawntime)
        {
            spawn();
            times = 0;
        }
    }

    public void spawn()
    {
        GameObject obg = fishpool.instance.getfishes();
        obg.transform.position = new Vector3(Random.Range(-120f, 120f), 1000f, 52f);
        obg.SetActive(true);
    }    
}
