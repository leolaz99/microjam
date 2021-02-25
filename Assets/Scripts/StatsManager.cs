using UnityEngine;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour
{
   [SerializeField] Text distance;
   [SerializeField] Text record;
    
    void Start()
    {
        distance.text = PlayerPrefs.GetFloat("distance").ToString("F2");
        record.text = PlayerPrefs.GetFloat("record").ToString("F2");
    }
}
