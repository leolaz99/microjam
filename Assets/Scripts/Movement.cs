using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    [HideInInspector] public Vector3 direction = Vector3.right;
    public static Movement instance;

    /// <summary>
    /// Funzione per far muovere la barretta
    /// </summary>
    void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.x > 6)
        {
            direction = Vector3.left;
        }

        if (transform.position.x < -6)
        {
            direction = Vector3.right;
        }
    }
    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Update()
    {
        Move();
    }
}
