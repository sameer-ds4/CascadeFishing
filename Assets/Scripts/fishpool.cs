using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishpool : MonoBehaviour
{
    public float amount;
    public GameObject fish;
    //public Transform range;
    int i;

    public List<GameObject> fishes;

    public static fishpool instance;

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
        fishes = new List<GameObject>();
        for(i=0; i<amount; i++)
        {
            GameObject obj = Instantiate(fish);
            obj.SetActive(false);
            fishes.Add(obj);
        }
    }

    public GameObject getfishes()
    {
        for(i = 0; i<fishes.Count; i++)
        {
            if(!fishes[i].activeInHierarchy)
                return fishes[i];
        }
        return null;
    }

    public void addfish(GameObject obj)
    {
        fishes.Add(obj);
    }
}
