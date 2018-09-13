using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotion : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float jumpPower = 1400;

    // Use this for initialization
    void Start()
    {

        transform.rotation = Quaternion.Euler(0, 90, 0);
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = this.gameObject.transform.position;

        transform.position += transform.TransformDirection(Vector3.forward * 0.1f);

        if (transform.position.x > 195f)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }

        if (transform.position.x < 69f)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Stage")
        {
            rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Force);
        }
    }
}
