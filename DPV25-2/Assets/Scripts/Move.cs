using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float velocidad;
    public float movVer, movHor;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movHor = Input.GetAxis("Horizontal");
        movVer = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movHor,0,movVer);

        rb.AddForce(movimiento*velocidad);
    }

    private void OnCollisionStay(Collision collision){
        if(collision.gameObject.tag == "Muro")
        {
            Destroy(collision.gameObject);
        }
        Debug.Log(collision.gameObject.name);
    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Muro")
        {
            Destroy(other.gameObject);
        }
    }
}
