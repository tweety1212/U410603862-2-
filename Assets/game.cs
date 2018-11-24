using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void b1() {
        SceneManager.LoadSceneAsync(1);
    }
    public void b2(){
        Application.Quit();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
