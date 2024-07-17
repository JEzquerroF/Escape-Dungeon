using UnityEngine;

public class AlarmController : MonoBehaviour
{
    [SerializeField] GameObject _alarm01;
    [SerializeField] GameObject _alarm02;
    [SerializeField] GameObject _alarm03;
    [SerializeField] GameObject _alarm04;
    [SerializeField] GameObject _alarm05;
    [SerializeField] GameObject _alarm06;

    [SerializeField] AudioSource _music;
    AudioSource _alarmMusic;

    public bool transition = false;

    private void Awake()
    {
        _alarmMusic = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        VisionDetector.OnplayerDetected += ActiveAlarm;
        PatrolEnemyBehaviour.OnPatrol += DisableAlarm;
    }

    private void OnDisable()
    {
        if (!transition)
        {
            VisionDetector.OnplayerDetected -= ActiveAlarm;
            PatrolEnemyBehaviour.OnPatrol -= DisableAlarm;
            transition = true;
        }
    }

    private void ActiveAlarm()
    {
        _alarm01.SetActive(true);
        _alarm02.SetActive(true);
        _alarm03.SetActive(true);
        _alarm04.SetActive(true);
        _alarm05.SetActive(true);
        _alarm06.SetActive(true);
        _music.Stop();
        _alarmMusic.Play();
    }

    private void DisableAlarm()
    {
        _alarm01.SetActive(false);
        _alarm02.SetActive(false);
        _alarm03.SetActive(false);
        _alarm04.SetActive(false);
        _alarm05.SetActive(false);
        _alarm06.SetActive(false);
        _music.Play();
        _alarmMusic.Stop();
    }
}
