using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float projectileSpeed = 10f; 
    [SerializeField] float projectilelifetime = 5f;
    [SerializeField] float firingRate = 0.2f;

    public bool isFiring; 

    Coroutine firingCoroutine;

    void Start()
    {
        
    }

    void Update()
    {
        Fire();
    }

    void Fire()
    {
       if (isFiring)
       {
        firingCoroutine = StartCoroutine(FireContinuously());
       }
       else 
       {
        StopCoroutine(firingCoroutine);
       }
    }

    IEnumerator FireContinuously()
    {
        while(true)
        {
            GameObject instance = Instantiate(projectilePrefab, 
            transform.position, Quaternion.identity);
            Destroy(instance, projectilelifetime);
            yield return new WaitForSeconds(firingRate);
        }
    }
}
