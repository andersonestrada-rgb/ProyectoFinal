using UnityEngine;

/*Contenido
Uso del método Transform para obtener las coordenadas del personaje
Asignación de velocidad al enemigo
Uso de Vector2 para obtener el valor vectorial de la distancia enemy - player, la homogenenizamos
Hacer que el enemigo recorra el vector resultante
*/

public class EnemyFollow : LifeEnemy
{
    private GameObject player;                      // Referencia del Player    

    [SerializeField] private float speed = 1f;    // Velocidad del enemigo    

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }     

    void Update()
    {        
        Vector2 direction = (Vector2)player.transform.position - (Vector2)transform.position;           // 1. Calcular dirección hacia el jugador (Vector2)        
        direction = direction.normalized;                                                                    // 2. Normalizar la dirección
        transform.position = (Vector2)transform.position + direction * speed * Time.deltaTime;  // 3. Mover al enemigo     
    }   
}