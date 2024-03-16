using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private ParticleSystem firePS;
    [SerializeField]
    private AudioSource fireAudio;

    private void Start()
    {
        firePS.Stop();
    }

    void Update()
    {
        fireAudio.Play();
        firePS.Play();

        GameObject tmpBullet = Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
