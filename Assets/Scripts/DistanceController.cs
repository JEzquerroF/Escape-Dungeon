using UnityEngine;

public class DistanceController : MonoBehaviour
{
    Vector2 previousPosition;
    Vector2 currentPosition;

    public float meterDistance;

    void Start()
    {
        currentPosition = transform.position;
        previousPosition = currentPosition;
    }

    void Update()
    {
        currentPosition = transform.position;

        if (!PlayerCaught.caughtPlayer)
        {
            float distance = Vector2.Distance(currentPosition, previousPosition);
            meterDistance += distance;
        }
        else
        {
            transform.position = new Vector3(-3.209f, -1.872f, 0.0f);
            currentPosition = transform.position;
            PlayerCaught.caughtPlayer = false;
        }

        previousPosition = currentPosition;
    }
}
