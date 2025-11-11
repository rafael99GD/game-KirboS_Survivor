using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CruzController : WeaponController
{

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    protected override void Attack()
    {
        base.Attack();
        GameObject spawnedCruz = Instantiate(weaponData.Prefab);
        spawnedCruz.transform.position = transform.position;
        spawnedCruz.GetComponent<CruzBehaviour>().DirectionChecker(pm.lastMovedVector);
    }
}
