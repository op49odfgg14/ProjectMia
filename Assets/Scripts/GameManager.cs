using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // Character Stats
    static private int Muscle = 0;
    static private int Finesse = 0;
    static private int Toughness = 0;
    static private int Smarts = 0;
    static private int Guts = 0;
    static private int Cunning = 0;

    // Scene index for going to next scene
    static private int SceneIndex = 0;

	// Use this for initialization
	void Start () {
        //DontDestroyOnLoad(this);

        /*
        Muscle = 0;
        Finesse = 0;
        Toughness = 0;
        Smarts = 0;
        Guts = 0;
        Cunning = 0;
        
        SceneIndex = 0;
        */
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void muscleIncrease () {
        Muscle = Muscle + 1;
        Debug.Log(Muscle);
    }

    public void muscleDecrease () {
        Muscle = Muscle - 1;
    }

    public void finesseIncrease () {
        Finesse = Finesse + 1;
    }

    public void finesseDecrease () {
        Finesse = Finesse - 1;
    }

    public void toughnessIncrease () {
        Toughness = Toughness + 1;
    }

    public void toughnessDecrease () {
        Toughness = Toughness - 1;
    }

    public void smartsIncrease () {
        Smarts = Smarts + 1;
    }

    public void smartsDecrease () {
        Smarts = Smarts - 1;
    }

    public void gutsIncrease () {
        Guts = Guts + 1;
    }

    public void gutsDecrease () {
        Guts = Guts - 1;
    }

    public void cunningIncrease () {
        Cunning = Cunning + 1;
    }

    public void cunningDecrease () {
        Cunning = Cunning - 1;
    }

    public void nextScene () {
        SceneIndex = SceneIndex + 1;
        //SceneManager.LoadScene(SceneIndex);
        Application.LoadLevel(SceneIndex);
    }

    /*
    void Awake() {
        DontDestroyOnLoad(this);
    }*/
}
