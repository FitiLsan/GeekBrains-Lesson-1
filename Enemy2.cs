using UnityEngine;
using System.Collections;

public class Enemy2 : MonoBehaviour
{
    public int Health;
    Rigidbody MyBody;

	// Use this for initialization
	void Start ()
    {
        MyBody = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void TakeDamage(int Damage)
    {
        Health--;

        if (Health <= 0)
        {
            MyBody.constraints = RigidbodyConstraints.None;
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
