using UnityEngine;

public class Points : MonoBehaviour
{
    bool isEnter = false;
    [SerializeField] GameObject bar;
    [SerializeField] float points;
    [SerializeField] KeyCode key;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isEnter = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isEnter = false;
    }

    private void Update()
    {
        if (isEnter)
        {
            if (Input.GetKeyDown(key))
            {
                GameManager.instance.i++;
                GameManager.instance.force += points;
                Movement.instance.direction = Vector3.left;
                bar.transform.position = new Vector2(-6, -3);
            }
        }
    }
}
