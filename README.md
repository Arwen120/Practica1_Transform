# Prácticas de Unity: Transformaciones y Movimiento

## Descripción del proyecto

Este repositorio contiene diez prácticas realizadas en Unity, centradas en el aprendizaje de las transformaciones, el movimiento de objetos, las rotaciones y los sistemas de seguimiento mediante objetivos y Waypoints.

A lo largo de las prácticas se han trabajado diferentes conceptos de programación en C# y herramientas de Unity, avanzando progresivamente desde movimientos básicos hasta sistemas de navegación más completos.

## Prácticas realizadas

### Práctica 1. Movimiento mediante Translate
Primer contacto con el movimiento de objetos en Unity mediante el método `Transform.Translate`. Se trabaja el desplazamiento de un objeto en una dirección determinada.

### Práctica 2. Movimiento normalizado
Se introduce la normalización de vectores para conseguir un movimiento consistente, evitando que la escala del vector afecte a la velocidad.

### Práctica 3. Movimiento hacia un objetivo
Se aprende a utilizar una posición objetivo mediante un componente `Transform` público, calculando la dirección desde el personaje hasta el objetivo.

### Práctica 4. Depuración con Debug.DrawRay
Se utiliza `Debug.DrawRay` para representar visualmente la dirección del movimiento en la ventana Scene y facilitar la depuración.

### Práctica 5. Seguimiento de un objetivo
Se implementa un sistema en el que un personaje persigue un objeto que puede desplazarse mediante las teclas de dirección. También se trabaja con la modificación de la velocidad.

### Práctica 6. Movimiento rectilíneo hacia el objetivo
Se combina la rotación del personaje hacia un objetivo con el desplazamiento hacia delante utilizando `Vector3.forward`.

### Práctica 7. Control del Jittering
Se estudia el problema del Jittering (vibración del movimiento) y se prueban diferentes soluciones mediante la distancia, la magnitud de los vectores y `Vector3.MoveTowards`.

### Práctica 8. Giro suave
Se sustituye la rotación instantánea por una rotación progresiva utilizando `Quaternion.Slerp` y `Quaternion.LookRotation`.

### Práctica 9. Recorrido mediante Waypoints
Se crea un circuito cerrado formado por cuatro Waypoints. El personaje localiza los puntos mediante etiquetas, los ordena y se desplaza automáticamente de uno a otro.

### Práctica 10. Sistema de Waypoints de Unity
Se utiliza el sistema de Waypoints proporcionado mediante la carpeta `Utility`. Se configura un circuito con `WaypointCircuit` y `WaypointProgressTracker`, y se implementa un script para que el personaje persiga al objetivo mientras este avanza por el recorrido.

## Tecnologías y herramientas utilizadas

- **Unity:** creación y configuración de escenas y objetos 3D.
- **C#:** programación de los scripts de movimiento y seguimiento.
- **Visual Studio:** edición y desarrollo de código.
- **Git:** control de versiones del proyecto.
- **GitHub:** almacenamiento y publicación del repositorio.

## Organización del repositorio

El proyecto contiene los siguientes elementos:

- `Assets/`: scripts, escenas, objetos y recursos utilizados.
- `Documentation/`: GIF de ejecución de las prácticas.
- `README.md`: descripción general del proyecto.
- `README2.md` hasta `README10.md`: documentación individual de cada práctica.

## Conclusión

Estas diez prácticas han permitido adquirir progresivamente conocimientos sobre el movimiento y las transformaciones en Unity, el uso de vectores y cuaterniones, la depuración y los sistemas de seguimiento.

También han servido para familiarizarse con la programación en C#, la organización de proyectos y el control de versiones mediante Git y GitHub.

El proyecto representa el proceso de aprendizaje y evolución a través de los diferentes ejercicios realizados.
