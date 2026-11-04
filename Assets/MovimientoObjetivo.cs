using JetBrains.Annotations;
using UnityEngine;

public class MovimientoObjetivo : MonoBehaviour
{
    public Transform goal;
    public float speed = 0.1f;

   void Start()
    {
        this.transform.LookAt(goal.position);
    }

    void Update()
    {
        Vector3 direction = goal.position - this.transform.position;

        this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
}