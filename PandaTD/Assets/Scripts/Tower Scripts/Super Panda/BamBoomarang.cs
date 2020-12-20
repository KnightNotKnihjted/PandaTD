using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamBoomarang : MonoBehaviour
{
    public float speed;
    public float lifetime;

    void Start(){
        Invoke("DestroyBamBoomerang", lifetime);
    }

    void Update(){
        transform.Translate(transform.up * speed * Time.deltaTime);
    }

    void DestroyBamBoomerang(){
        Destroy(gameObject);
    }
}