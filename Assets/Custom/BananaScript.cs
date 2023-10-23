using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaScript : MonoBehaviour
{
    //public float speed;
    public AudioSource source;
    public AudioClip clip;
    public GameObject CheeseWall;
    //private Transform trans;
    
    
    
    void Start()
    {
        //trans = transform;
    }
    
    void Update()
    {
        //trans.eulerAngles += new Vector3(0, speed, 0);
    }
    
    void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(clip);
        gameObject.SetActive(false);
        CheeseWall.SetActive(false);
    }
}
