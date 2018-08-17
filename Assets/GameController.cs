using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour {

  private GameStateController StateController;


  // Use this for initialization
  void Start () {

    StateController = FindObjectOfType<GameStateController>();
    GameObject hero1 = Resources.Load("HeroObject") as GameObject;
    GameObject hero1Instance = Instantiate(hero1);
    hero1Instance.transform.parent = GameObject.Find("Tilemap").transform;
    hero1Instance.AddComponent<HeroObject>().createHero(0.64f, 1.92f, "Knight", "Solaire", 2, 1200, "");

    GameObject hero2 = Resources.Load("HeroObject") as GameObject;
    GameObject hero2Instance = Instantiate(hero2);
    hero2Instance.transform.parent = GameObject.Find("Tilemap").transform;
    hero2Instance.AddComponent<HeroObject>().createHero(-1.92f, 1.92f, "Wizard", "Gandalf", 1, 200, "");


  }

}
