﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	[SerializeField] GameObject hero;
	[SerializeField] GameObject tanker;
	[SerializeField] GameObject soldier;
	[SerializeField] GameObject ranger;

	private Animator heroAnim;
	private Animator tankerAnim;
	private Animator soldierAnim;
	private Animator rangerAnim;

	void Awake() {
		Assert.IsNotNull (hero);
		Assert.IsNotNull (tanker);
		Assert.IsNotNull (ranger);
		Assert.IsNotNull (soldier);
	}




	// Use this for initialization
	void Start () {

		heroAnim = hero.GetComponent<Animator> ();
		tankerAnim = tanker.GetComponent<Animator> ();
		rangerAnim = ranger.GetComponent<Animator> ();
		soldierAnim = soldier.GetComponent<Animator> ();

		StartCoroutine(showcase());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator showcase() {
		yield return new WaitForSeconds (1f);
		heroAnim.Play ("SpinAttack");
		yield return new WaitForSeconds (1f);
		tankerAnim.Play ("Attack");
		yield return new WaitForSeconds (1f);
		soldierAnim.Play ("Attack");
		yield return new WaitForSeconds (1f);
		rangerAnim.Play ("Attack");
		yield return new WaitForSeconds (1f);

		StartCoroutine (showcase ());
	}

	public void Battle() {
		SceneManager.LoadScene ("Level");
	}

	public void Quit() {
		Application.Quit ();
	}
}
