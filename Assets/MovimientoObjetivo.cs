using JetBrains.Annotations;
using UnityEngine;

public class MovimientoObjetivo : MonoBehaviour
{
    public Vector3 goal;
    public float speed = 0.1f;

   

    void Update()
    {
        this.transform.Translate(goal.normalized * speed * Time.deltaTime);
    }
}