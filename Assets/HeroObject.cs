using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroObject : SelectableObject {

	// base stats
	public int AttackScore;
	public int DefenseScore;
	public int KnowledgeScore;
	public int PowerScore;

	// current and next experience
	public int CurrentExperience;
	public int NextLevelExperience;

	// class, name, portrait
	public string HeroClass;
	public string HeroName;

	void Start() {
		AttackScore = 1;
		DefenseScore = 1;
		KnowledgeScore = 1;
		PowerScore = 1;
		CurrentExperience = 0;
		NextLevelExperience = 1;
		HeroName = "TEST";
		Debug.Log("alright");
	}


}
