using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealPoint : MonoBehaviour
{
    private int _healPoint = 90;
    private void FixedUpdate()
    {
        if (_healPoint <= 0)
        {
            GetComponent<Animator>().SetInteger("Zombie", 2);
            Invoke("Destroy",4f);
        }
    }
    private void Destroy()
    {
        Destroy(gameObject);
        Shop._zombieCoin += Random.Range(3, 7);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            _healPoint -= Bullet._damage;
        }
    }
}
