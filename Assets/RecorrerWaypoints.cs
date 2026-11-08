using UnityEngine;
using System;

public class RecorrerWaypoints : MonoBehaviour
{
    private GameObject[] waypoints;
    private int waypointActual = 0;

    public float velocidad = 2f;
    public float distanciaMinima = 0.2f;

    void Start()
    {
        waypoints = GameObject.FindGameObjectsWithTag("waypoint");

        Array.Sort(waypoints, (a, b) => a.name.CompareTo(b.name));
    }

    void Update()
    {
        if (waypoints.Length == 0)
        {
            return;
        }

        Transform objetivo = waypoints[waypointActual].transform;

        Vector3 direccion = objetivo.position - transform.position;

        if (direccion.magnitude < distanciaMinima)
        {
            waypointActual++;

            if (waypointActual >= waypoints.Length)
            {
                waypointActual = 0;
            }

            return;
        }

        Quaternion rotacionObjetivo = Quaternion.LookRotation(direccion);

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            rotacionObjetivo,
            velocidad * Time.deltaTime
        );

        transform.position = Vector3.MoveTowards(
    transform.position,
    objetivo.position,
    velocidad * Time.deltaTime
);
    }
}
