// Trap.cs
using UnityEngine;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (LifeData.lifePoint > 0)
            {
                LifeData.lifePoint--;
            }
        }
    }
}

