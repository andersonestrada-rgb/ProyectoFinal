using UnityEngine;

/*Contenido
Hacer uso del script para hacer explotar al enenigo al colisionar con el player
*/

public class EnemyTwoAttack : MonoBehaviour
{
    [SerializeField] private ControlPersonaje controlPersonaje;

    public void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.CompareTag("Player")) //Comparar colisión para realizar la detonación del enemigo y causar daño
        {
            Destroy(gameObject);
            controlPersonaje.lifePlayer -= 15;
            print(controlPersonaje.lifePlayer);
        }
    }
}
