using System;
using UnityEngine;

public class HeroSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			SelectHero();
		}

	}

	void SelectHero() {

		Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		RaycastHit2D[] hits = Physics2D.LinecastAll(clickPosition, clickPosition);

		if (hits.Length != 0) {
			// if object that has this script attached is not current selection,
			// destroy attached controls script
			if (gameObject != hits[0].collider.gameObject) {
				Destroy(gameObject.GetComponent<HeroControls>());
			}

			HeroControls hc = hits[0].collider.gameObject.GetComponent(typeof (HeroControls)) as HeroControls;
			if (hc == null) {
			    hits[0].collider.gameObject.AddComponent<HeroControls>();
			}
		}

	}
}
