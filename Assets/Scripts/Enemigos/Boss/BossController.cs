using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

/* Contenido
Control de Spawn
Creación de enemigos alrededor del jugador
Asignación de vida del enemigo
Uso de cortina para intervalos a modo de prevención de saturación
Condiciones de comparación por colisión por Trigger (Destrucción por vida)
*/

public class BossController : MonoBehaviour
{    
    [SerializeField] private GameObject SpawnPrefabEnemy;
    [SerializeField] private GameObject Player;
    [SerializeField] private const float radioSpawn = 6f;    
    private bool BossHave = false;    

    void Update()
    {
        if (LifeEnemy.NumberEnemyDeathGet() >= LifeEnemy.RequiredEnemyDeathGet() && !BossHave) //medoto estático para obtener el número de enemigos muertos y el requerido
        {            
            Spawner();
            BossHave = true;
        }
    }

    public void Spawner()
    {
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);

        Vector2 direccion = new Vector2(x, y).normalized; //Normalizamos los ejes "x" como "y"     
        Vector2 spawnPos = (Vector2)Player.transform.position + direccion * radioSpawn;
        Instantiate(SpawnPrefabEnemy, spawnPos, SpawnPrefabEnemy.transform.rotation);
    }



}
