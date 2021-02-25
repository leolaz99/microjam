using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int i = 0;
    public float force = 0;
    public static GameManager instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
