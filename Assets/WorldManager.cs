using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour {

    public GameObject GroundNode;
    public GameObject PathNode;

    private string levelString = "[1,1,1,1,1,1,1,2]";

    // Use this for initialization
    void Start () {
        int[] l = JsonUtility.FromJson<int[]>(levelString);
        foreach(int i in l)
        {
            Debug.LogError(i);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
