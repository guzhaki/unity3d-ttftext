using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class MyMesh0 : MonoBehaviour {
	public float alpha=30;
	Material m;
	Shader s;
	
	// Use this for initialization
	void Start () {
		//renderer.material=new Material(Shader.Find ("Custom/MyMesh0"));
	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.SetFloat("_cosalpha",Mathf.Cos(alpha));
		renderer.material.SetFloat("_sinalpha",Mathf.Sin(alpha));		
	}
}
