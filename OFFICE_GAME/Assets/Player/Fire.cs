using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 50;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        //move right according to the speed
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Monsters monsters = hitInfo.GetComponent<Monsters>();
        if (monsters != null)
        {
            monsters.TakeDamage(damage);
        }


        Destroy(gameObject);
    }


}
