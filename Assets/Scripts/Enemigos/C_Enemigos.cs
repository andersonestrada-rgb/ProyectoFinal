using UnityEngine;
using System.Collections;

public class C_Enemigos : MonoBehaviour
{
    [SerializeField] private GameObject SpawnPrefabEnemy;
    [SerializeField] private GameObject Player;
    [SerializeField] private float radioSpawneo = 5f; 
    [SerializeField] private float espera = 3f;
    public int life = 3;
    private bool activarCreacion;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            activarCreacion = !activarCreacion;

            if (activarCreacion)
            {                
                StartCoroutine(CortinaDeSpawneo());
                print("Spawner Activado");
            }
            else
            {
                StopCoroutine(CortinaDeSpawneo());
                Destroy(SpawnPrefabEnemy);
                print("Spawner Desactivado");
            }
        }
    }

    public void Spawner()
    {       
        float x = Random.Range(0f, 2f);
        float y = Random.Range(0f, 2f);
        
        Vector2 direccion = new Vector2(x, y).normalized;        
        Vector2 spawnPos = (Vector2)Player.transform.position + direccion * radioSpawneo;      
        GameObject enemy = Instantiate(SpawnPrefabEnemy);
        enemy.transform.position = spawnPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("trigger entro: " + collision.tag);
        if (collision.tag == "Bullet")
        {
            life--;
            if (life <= 0)
            Destroy(SpawnPrefabEnemy);
        }        
    }
    /*
    public void OnTriggerExit2D(Collider2D collision)
    {

    }

    public void OnTriggerStay2D(Collider2D collision)
    {

    }
    */
    IEnumerator CortinaDeSpawneo()
    {
        while (activarCreacion)
        {
            Spawner();
            yield return new WaitForSeconds(espera);
        }       
    }
}
