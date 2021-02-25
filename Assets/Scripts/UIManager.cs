using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] GameObject rocket;

    void Update()
    {
        text.text = rocket.transform.position.y.ToString("F2");
    }
}
