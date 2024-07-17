using System;
using UnityEngine;

public class PlayerCaught : MonoBehaviour
{
    public static bool caughtPlayer = false;
    public static Action OnPlayeCaught;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            caughtPlayer = true;
            OnPlayeCaught?.Invoke();
        }
    }
}
