using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CandyController : MonoBehaviour
{

    private AudioSource audioSource;
    public int points;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Collector"))
        {
            Destroy(this.gameObject);
        }
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);

        }
    }

}
