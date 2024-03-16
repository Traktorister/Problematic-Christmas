using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private ParticleSystem particlesystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Death();
        }
    }

    private void Death()
    {
        particlesystem.Play();
        this.gameObject.SetActive(false);
        Destroy(this.gameObject);
    }
}
