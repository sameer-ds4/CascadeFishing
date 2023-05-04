using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowshoot : MonoBehaviour
{
    public Rigidbody arrow;
    public float speed;
    public float shootspeed;
    public float rotationlvl;
   // public float spawntime;
    
    // Start is called before the first frame update
    void Start()
    {
        arrow = GetComponent<Rigidbody>();
        transform.position = arrow.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rotationlvl += Input.GetAxis("Mouse Y") * speed;
            transform.rotation = Quaternion.Euler(180 , rotationlvl, 0);
            if (rotationlvl < -20f)
                rotationlvl = -19f;
            if (rotationlvl > 20)
                rotationlvl = 19;
        }
        if(Input.GetMouseButtonUp(0))
        {
            arrow.AddForce(transform.forward * -shootspeed, ForceMode.Impulse);
        }     
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("wall"))
        {
            arrowspawn.instance.spawner();
            gameObject.SetActive(false);
            arrowpool.instance.addarrow(gameObject);
        }
        if (collision.collider.CompareTag("fish"))
        {
            Scoremanager.instance.scoring();
            arrowspawn.instance.spawner();
            gameObject.SetActive(false);
            arrowpool.instance.addarrow(gameObject);
        }    
    }
}
