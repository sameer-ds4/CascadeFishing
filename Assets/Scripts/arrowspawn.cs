using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowspawn : MonoBehaviour
{
    public GameObject temparrow;
    public Transform spawnpoint;

    public static arrowspawn instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        //temparrow = arrowpool.instance.arrow;
    }

    // Update is called once per frame
    /*void Update()
    {
        if(!arrowpool.instance.arrow.activeInHierarchy)
        {
            spawner();
        }
    }*/

    public void spawner()
    {
        GameObject obj = arrowpool.instance.getarrow();
        obj.transform.position = spawnpoint.position;
        obj.transform.rotation = spawnpoint.rotation;
        obj.SetActive(true);
    }
}
