using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] Text _timer;
    [SerializeField] Text _meters;

    [SerializeField] TimeController _timeController;
    [SerializeField] DistanceController _distanceController;

    public static float score;

    void Update()
    {
        _timer.text = string.Format("{0:00}:{1:00}:{2:00}", _timeController.minutes, _timeController.seconds, _timeController.cents);
        _meters.text = _distanceController.meterDistance.ToString("0.0") + " meters";
        
        score = 500.0f - (_timeController.time + _distanceController.meterDistance);
    }
}
 