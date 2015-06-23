using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
