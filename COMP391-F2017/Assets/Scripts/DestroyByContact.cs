using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
    public GameObject explosionPlayer;
    public GameObject explosion;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Instantiate(explosionPlayer, other.gameObject.transform.position, other.gameObject.transform.rotation);
        }

        Instantiate(explosion, this.transform.position, this.transform.rotation);

        Destroy(other.gameObject); // Destroying the "other" thing
        Destroy(this.gameObject); // Destroying this thing
    }
}
