using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class Bullet2 : MonoBehaviour
{
    public float Force;
    public int Damage;

	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * Force, ForceMode.Impulse);

        Destroy(gameObject, 2);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider Касание)
    {
        if (Касание.gameObject.tag == "Enemy")
        {
            Касание.GetComponent<Enemy2>().TakeDamage(Damage);
            Destroy(gameObject);
        }
    }
}
