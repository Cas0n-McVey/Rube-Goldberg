using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
 
   [SerializeField] AudioClip bump;
   [SerializeField] AudioClip crash;
   AudioSource audio;
   void Start()
   {
     audio = GetComponent<AudioSource>();
   }
   void OnCollisionEnter(Collision collision) //Plays Sound Whenever collision detected
   {
       if (collision.gameObject.tag == "Chain")
       {
          audio.PlayOneShot(crash);
       }
       if (collision.gameObject.tag == "Door")
       {
          audio.PlayOneShot(crash);
       }
       if (collision.gameObject.tag == "Ramp")
       {
          audio.PlayOneShot(bump);
       }
   }
}

