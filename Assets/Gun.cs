using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float speed = 40;
    public GameObject bullet;
    public Transform barrel;
    public AudioSource audioSource;
    public AudioClip audioClip;


    // Start is called before the first frame update
    
    public void Fire()
    {
        GameObject spanwedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
        spanwedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
        audioSource.PlayOneShot(audioClip);
        Destroy(spanwedBullet, 2);
    }
}
