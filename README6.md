 Práctica 6 – Movimiento rectilíneo hacia el objetivo

 Objetivo

Realizar un movimiento rectilíneo hacia un objetivo. Para ello, el personaje debe girar primero hacia el objetivo y después avanzar en la dirección de su vector `forward` local.

 Script: SeguirObjetivoForward.cs

```csharp
using UnityEngine;

public class SeguirObjetivoForward : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 2f;

    void Update()
    {
        transform.LookAt(objetivo);

        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
}
```

 Explicación

- **objetivo:** referencia al objeto que queremos alcanzar.
- **velocidad:** controla la rapidez del movimiento.
- **LookAt():** gira el personaje para que mire hacia el objetivo.
- **Vector3.forward:** permite avanzar por el eje Z local del personaje.
- **Time.deltaTime:** mantiene un movimiento independiente de la velocidad de fotogramas.

 Resultado

El personaje gira hacia el objetivo y avanza en línea recta siguiendo su dirección `forward` local.

![Demostración de la práctica 6](Documentation/Practica6_Transform.gif)