using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapInit: MonoBehaviour {

  // Use this for initialization
  void Start () {
    Debug.Log("test init");
    GameObject hero1 = (GameObject)Instantiate(Resources.Load("HeroObject"));
    Vector3 hero1Position = new Vector3(1.92f, 1.92f, -1);
    hero1.transform.position += hero1Position;
    GameObject hero2 = (GameObject)Instantiate(Resources.Load("HeroObject"));
    Vector3 hero2Position = new Vector3(5.76f, 1.92f, -1);
    hero2.transform.position += hero2Position;
    GameObject hero3 = (GameObject)Instantiate(Resources.Load("HeroObject"));
    Vector3 hero3Position = new Vector3(-1.92f, 3.2f, -1);
    hero3.transform.position += hero3Position;
  }

}
