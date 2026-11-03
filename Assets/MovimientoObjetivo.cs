using JetBrains.Annotations;
using UnityEngine;

public class MovimientoObjetivo : MonoBehaviour
{
    public Vector3 goal;

   

    void Update()
    {
        this.transform.Translate(goal);
        goal = goal * 2.0f;
    }
}