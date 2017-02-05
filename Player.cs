using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class Player : MonoBehaviour
{
    public GameObject Bullet, StartBullet;
    public Rigidbody MyBody;
    public float Speed;
    private Vector3 Movement;


	// Use this for initialization
	void Start ()
    {
        MyBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
            Fire();
	}

    void FixedUpdate()
    {
        float Right = Input.GetAxisRaw("Horizontal");
        float Forward = Input.GetAxisRaw("Vertical");

        Movement.Set(Forward, 0f, Right);

        MyBody.AddForce(transform.forward * Forward * Speed, ForceMode.Impulse);
        MyBody.AddForce(transform.right * Right * Speed, ForceMode.Impulse);
    }

    void Fire()
    {
        Instantiate(Bullet, StartBullet.transform.position, StartBullet.transform.rotation);
    }


}
