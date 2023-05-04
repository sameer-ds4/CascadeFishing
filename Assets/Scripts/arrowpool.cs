using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowpool : MonoBehaviour
{
    public static arrowpool instance;

    public float amount;
    public GameObject arrow;
    public Transform loc;

    public int i;

    private List<GameObject> arrows;

    public void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        arrows = new List<GameObject>();
        Instantiate(arrow, loc.position, loc.rotation);
        for(i=0; i<amount; i++)
        {
            GameObject obj = Instantiate(arrow, loc.position, loc.rotation);
            obj.SetActive(false);
            arrows.Add(obj);
        }
    }

    public GameObject getarrow()
    {
        for(i=0; i<arrows.Count; i++)
        {
            if (!arrows[i].activeInHierarchy)
                return arrows[i];
        }
        return null;
    }

    public void addarrow(GameObject obj)
    {
        arrows.Add(obj);
    }

   /* public void Update()
    {
        if(!arrow.activeInHierarchy)
        {
            getarrow();
        }
    }*/
}
