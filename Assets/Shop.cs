using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {
    BuildManager buildmanager;
    void Start()
    {
        buildmanager = BuildManager.instance;
    }

    public void PurchaseStandartTurret ()
    {
        Debug.Log("standart Turret");
        buildmanager.SetTurretToBuild(buildmanager.standardTurretPrefab);
    }
    public void PurchaseAnotherTurret ()
    {
        Debug.Log("another");
        buildmanager.SetTurretToBuild(buildmanager.anotherTurretPrefab);
    }
}
