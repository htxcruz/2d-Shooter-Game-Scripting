using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingEnemy : MonoBehaviour
{
    Rigidbody2D eBody;
    // Start is called before the first frame update
    void Start()
    {
        eBody = this.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ground")
        {
            eBody.velocity = new Vector2(0, 0);
            eBody.AddForce(new Vector2(0, 15), ForceMode2D.Impulse);
        }

        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
        }

    }

}