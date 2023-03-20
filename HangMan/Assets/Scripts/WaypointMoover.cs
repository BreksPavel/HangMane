using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMoover : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaipontIndex = 0;

    [SerializeField] private float speed = 2f;
    private void Update()
    {
        if (Vector2.Distance(waypoints[currentWaipontIndex].transform.position, transform.position) < .1f)
        {
            currentWaipontIndex++;
            if (currentWaipontIndex >= waypoints.Length)
                currentWaipontIndex = 0;
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaipontIndex].transform.position, Time.deltaTime * speed);
    }
}
