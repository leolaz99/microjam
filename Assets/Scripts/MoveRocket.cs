using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveRocket : MonoBehaviour
{
    bool isStarted = false;
    [SerializeField] Rigidbody2D rb;


    void Update()
    {
        if(GameManager.instance.i == 5 && isStarted == false)
        {
            isStarted = true;
            rb.AddForce(Vector2.up * GameManager.instance.force, ForceMode2D.Impulse);
        }

        if (rb.velocity.y <= 0 && isStarted == true)
        {
            PlayerPrefs.SetFloat("distance", rb.position.y);
            
            if (rb.position.y > PlayerPrefs.GetFloat("record", 0))
            { 
                PlayerPrefs.SetFloat("record", rb.position.y);
            }

            SceneManager.LoadScene("End Scene");
        }
            
    }
}
