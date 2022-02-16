using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponAmmoUI : MonoBehaviour
{
    [SerializeField] 
    private TextMeshProUGUI weaponNameText;
    [SerializeField] 
    private TextMeshProUGUI currentBulletCountText;
    [SerializeField] 
    private TextMeshProUGUI totalBulletCountText;
    [SerializeField] 
    private WeaponComponent weaponComponent;


    // Start is called before the first frame update
    private void OnEnable()
    {
        PlayerEvents.OnWeaponEquipped += OnWeaponEquipped;
    }

    private void OnDisable()
    {
        PlayerEvents.OnWeaponEquipped -= OnWeaponEquipped;
    }

    private void OnWeaponEquipped(WeaponComponent _weaponCompnent)
    {
        weaponComponent = _weaponCompnent;
    }

    // Update is called once per frame
    void Update()
    {
        if (!weaponComponent)
        {
            return;
        }

        weaponNameText.text = weaponComponent.weaponStats.weaponName;
        currentBulletCountText.text = weaponComponent.weaponStats.bulletsInClip.ToString();
        totalBulletCountText.text = weaponComponent.weaponStats.totalBullets.ToString();

    }
}
