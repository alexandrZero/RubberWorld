using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGun : MonoBehaviour
{
    [SerializeField] private bool _isPistol;
    [SerializeField] private bool _isMachineGun;
    [SerializeField] private bool _isSnipeGun;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && _isPistol)
        {
            GunMenu._havePistol = true;
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Player" && _isMachineGun)
        {
            GunMenu._haveMachineGun = true;
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Player" && _isSnipeGun)
        {
            GunMenu._haveSnipeGun = true;
            Destroy(gameObject);
        }
    }
}
