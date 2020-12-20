using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chickin : MonoBehaviour
{
    private GameMaster gm;

    public float speed;
    private Waypoints Wpoints;

    private int waypointIndex;

    void Start(){
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        Wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
    }
    void Update(){
        transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints[waypointIndex].position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, Wpoints.waypoints[waypointIndex].position) < 0.1){
            if(waypointIndex < Wpoints.waypoints.Length - 1){
                waypointIndex++;
            }
            else{
                gm.lives--;
                Destroy(gameObject);
            }
        }
    }
}