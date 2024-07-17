using UnityEngine;

public class TimeController : MonoBehaviour
{
    public float time;
    public int minutes, seconds, cents;

    void Update()
    {
        time += Time.deltaTime;
        minutes = (int)(time / 60f);
        seconds = (int)(time - minutes * 60f);
        cents = (int)((time - (int)time) * 100f);
    }
}
