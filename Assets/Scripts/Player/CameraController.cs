using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player; //Ubicación del player en la escena    
    public float suavizadoDeMovimiento = 5f;

    public GameObject Target;
    public float cameraSpeed;
    public float cameraRange;

    private void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        CameraMovementMachine();
        /*
        if (Player == null) return;
        Vector2 nuevaPosicion = new Vector2(Player.position.x, Player.position.y);
        transform.position = Vector2.Lerp(transform.position, nuevaPosicion, suavizadoDeMovimiento * Time.deltaTime);
        */
    }


    public void CameraMovementMachine()
    {
        float distance = Vector2.Distance(Target.transform.position, transform.position);

        if (distance >= cameraRange)
        {
            Vector3 target = Target.transform.position;
            target.z = -10;
            Vector3 dir = (Target.transform.position - transform.position).normalized;
            transform.position += dir * cameraSpeed * Time.deltaTime;
        }
    }



}