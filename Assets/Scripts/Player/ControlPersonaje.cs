using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    public GameObject BulletPrefab;

    public float Speed;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
            ShootProyectile();

        if (Input.GetMouseButton(0))
            MoveToDirection();
    }

    public void MoveToDirection()
    {
        Vector2 worldPositon = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 moveDirection = (worldPositon - (Vector2)transform.position).normalized;

        transform.position += moveDirection * Speed * Time.deltaTime;
    }

    public void ShootProyectile()
    {
        //-> obtener posicon del mouse respecto a la resolucion de la patanlla
        Vector2 mousePosition = Input.mousePosition;
        // convirtiendo la posicon del mouse a la posicion en el mundo
        Vector2 worldPositon = Camera.main.ScreenToWorldPoint(mousePosition);
        //calculdo la direccion de disparo
        Vector2 shootDirection = worldPositon - (Vector2)transform.position;
        //normalizando la direccion
        Vector2 normalizeShootDirection = shootDirection.normalized;
        //-> Crear 
        GameObject bullet = Instantiate(BulletPrefab);

        bullet.transform.position = transform.position;

        bullet.transform.up = normalizeShootDirection;

        print(worldPositon);
    }
}
