using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GunMenu : MonoBehaviour
{
    [SerializeField] private TextMesh _textCount;
    [SerializeField] private GameObject _pistol;
    [SerializeField] private GameObject _machineGun;
    [SerializeField] private GameObject _snipeGun;
    [SerializeField] private GameObject _fence;
    public static bool _havePistol = true;
    public static bool _haveMachineGun;
    public static bool _haveSnipeGun;
    public static bool _haveFence;
    public static bool _nowPistol = true;
    public static bool _nowMachineGun;
    public static bool _nowSnipeGun;
    public static bool _nowFence;
    private void Start()
    {
        CameraWatch.playerGameObject = _pistol;
    }
    private void FixedUpdate()
    {
        if (_nowPistol)
        {
          _textCount.text = Bullet._currentBulletPistol.ToString() + "/" + Bullet._countBulletPistol.ToString();
        }
        if (_nowMachineGun)
        {
          _textCount.text = Bullet._currentBulletMachineGun.ToString() + "/" + Bullet._countBulletMachineGun.ToString();
        }
        if (_nowSnipeGun)
        {
           _textCount.text = Bullet._currentBulletSnipe.ToString() + "/" + Bullet._countBulletSnipe.ToString();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && SnipeGun._isAim == false)
        {
            CameraWatch.playerGameObject = GameObject.FindWithTag("Player");
            _pistol.SetActive(false);
            _snipeGun.SetActive(false);
            _machineGun.SetActive(false);
            _fence.SetActive(false);
            _nowPistol = false;
            _nowMachineGun = false;
            _nowSnipeGun = false;
            _nowFence = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && _havePistol && SnipeGun._isAim == false)
        {
            CameraWatch.playerGameObject = _pistol;
            _pistol.SetActive(true);
            _snipeGun.SetActive(false);
            _machineGun.SetActive(false);
            _fence.SetActive(false);
            _nowPistol = true;
            _nowMachineGun = false;
            _nowSnipeGun = false;
            _nowFence = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && _haveMachineGun && SnipeGun._isAim == false)
        {
            CameraWatch.playerGameObject = _machineGun;
            _pistol.SetActive(false);
            _snipeGun.SetActive(false);
            _fence.SetActive(false);
            _machineGun.SetActive(true);
            _nowPistol = false;
            _nowMachineGun = true;
            _nowSnipeGun = false;
            _nowFence = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && _haveSnipeGun)
        {
            CameraWatch.playerGameObject = _snipeGun;
            _pistol.SetActive(false);
            _machineGun.SetActive(false);
            _fence.SetActive(false);
            _snipeGun.SetActive(true);
            _nowPistol = false;
            _nowMachineGun = false;
            _nowFence = false;
            _nowSnipeGun = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && _haveFence)
        {
            CameraWatch.playerGameObject = gameObject;
            _pistol.SetActive(false);
            _machineGun.SetActive(false);
            _snipeGun.SetActive(false);
            _fence.SetActive(true);
            _nowPistol = false;
            _nowMachineGun = false;
            _nowFence = true;
            _nowSnipeGun = false;
        }
    }
}
