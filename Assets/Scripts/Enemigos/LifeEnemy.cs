using UnityEngine;

public class LifeEnemy : MonoBehaviour
{
    [SerializeField] private int lifeEnemy = 4;
    private static int NumberEnemyDeath;       //Contador estático para el número de enemigos muertos
    private const int RequiredEnemyDeath = 25; //Número requerido de enemigos muertos para activar la invocación del jefe

    public void CountEnemyDeath()
    {
        NumberEnemyDeath++;
        print("Número de enemigos muertos: " + NumberEnemyDeath);
    }

    public void WinCondition()
    {
        if (NumberEnemyDeath >= RequiredEnemyDeath)
        {
            print("¡Ahora debemos acabar con el más fuerte!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("trigger entro: " + collision.tag);
        if (collision.CompareTag("ShotPlayer"))
        {
            lifeEnemy--;
            //print("Enemigo 1 tiene de vida: " + lifeEnemy);
            if (lifeEnemy <= 0)
            {
                Destroy(gameObject);
                CountEnemyDeath();
                WinCondition();
            }                
        }
    }

    public static int NumberEnemyDeathGet()
    {
        return NumberEnemyDeath;
    }

    public static int RequiredEnemyDeathGet()
    {
        return RequiredEnemyDeath;
    }
}
