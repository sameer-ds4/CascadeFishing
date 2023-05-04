using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishcontrol : MonoBehaviour
{
    public Rigidbody fishy;
    public float fallspeed;
    // Start is called before the first frame update
    void Start()
    {
        fishy = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        fishy.transform.rotation = Quaternion.Euler(-90f, 0, 0);
        fishy.velocity = Vector2.down * fallspeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("wall"))
        {
            gameObject.SetActive(false);
            fishpool.instance.addfish(gameObject);
        }
        if(collision.collider.CompareTag("arrow"))
        {
            gameObject.SetActive(false);
            fishpool.instance.addfish(gameObject);
        }
    }
}
