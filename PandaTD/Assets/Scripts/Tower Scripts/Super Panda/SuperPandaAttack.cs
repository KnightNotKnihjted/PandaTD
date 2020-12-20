using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperPandaAttack : MonoBehaviour
{
    public GameObject bamBoomarang;
    public float shotSpeed;
    public float startShotSpeed;
    public int damage;
    public Transform shotPos;

    void Start(){
        shotSpeed = startShotSpeed;
    }

    void Update(){
        if(shotSpeed < 0){
            Shoot();
        } else if(shotSpeed > 0){
            shotSpeed -= Time.deltaTime;
        }
    }
    void Shoot(){
        shotSpeed = startShotSpeed;
        Instantiate(bamBoomarang, shotPos.position, Quaternion.identity);
    }
}