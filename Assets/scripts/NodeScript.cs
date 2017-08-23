using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NodeScript : MonoBehaviour {
    [Header("Attributes")]
    public Color hovercolor;
    public Vector3 offset;


    private GameObject turret;

    private Renderer rend;
    private Color startColor;
    BuildManager buildManager;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
	}
    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            
            return;
        }

        if (buildManager.GetTurretToBuild() == null)
            return;

        if(turret != null)
        {
            Debug.Log("Can't build there! ToDo : Display");
            return;
        }
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position+offset, transform.rotation);

        //build a turret
    }
    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;


        if (buildManager.GetTurretToBuild() == null)
            return;

        rend.material.color = hovercolor;

    }
    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
 


}
