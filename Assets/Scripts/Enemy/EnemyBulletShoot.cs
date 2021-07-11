using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletShoot : MonoBehaviour
{
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    public GameObject projectile;
    public Transform player;
    public Transform firepoint;

    private void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < 10f)
        {
            AttackPlayer();
        }   
    }

    private void AttackPlayer()
    {
        transform.LookAt(player);

        if (!alreadyAttacked)
        {
            Rigidbody rb = Instantiate(projectile, firepoint.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(firepoint.forward * 32f, ForceMode.Impulse);
            rb.AddForce(firepoint.up * 6f, ForceMode.Impulse);


            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }
    private void ResetAttack()
    {
        alreadyAttacked = false;
    }
}
