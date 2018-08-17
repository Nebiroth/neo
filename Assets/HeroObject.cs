using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroObject : SelectableObject {

	public void createHero(float xPos, float yPos, string className, string heroName, uint level, uint currentXP, string PortraitPath) {
		Vector3 PosVector = new Vector3(xPos, yPos, 0.0f);
		transform.position += PosVector;
		HeroClass = className;
		// test for stats setting, make function later
		if (className == "Knight") {
			AttackScore = 2;
			DefenseScore = 4;
			KnowledgeScore = 1;
			PowerScore = 0;
		}
		if (className == "Wizard") {
			AttackScore = 0;
			DefenseScore = 1;
			KnowledgeScore = 3;
			PowerScore = 2;
		}

		HeroName = heroName;
		HeroLevel = level;
		CurrentExperience = currentXP;
		NextLevelExperience = level * 1000;
	}

	// base stats
	public uint AttackScore;
	public uint DefenseScore;
	public uint KnowledgeScore;
	public uint PowerScore;

	// current and next experience
	public uint HeroLevel;
	public uint CurrentExperience;
	public uint NextLevelExperience;

	// class, name, portrait
	public string HeroClass;
	public string HeroName;

	void Start() {

	}


}
