using UnityEngine;
using System.Collections;

public class SlideFix : MonoBehaviour {
	
	//private ControllerScriptCS controller;
	
	private Animator anim;
	
	void Start ()
	{
		anim = GetComponent<Animator>();
	}
	
	public void StopDucking ()
	{
		anim.SetBool ("DuckAnim", false);
		anim.SetBool ("RunAnim", true);
	
	}
}
