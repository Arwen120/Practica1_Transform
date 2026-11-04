using UnityEngine;

public class SeguirObjetivo : MonoBehaviour
{


    public Transform objetivo;

    public float velocidad = 2f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            velocidad += 1f;
        }


        Vector3 direccion = objetivo.position - transform.position;

        transform.position = Vector3.MoveTowards(
            transform.position,
            objetivo.position,
            velocidad * Time.deltaTime
        
         );
    }
}
