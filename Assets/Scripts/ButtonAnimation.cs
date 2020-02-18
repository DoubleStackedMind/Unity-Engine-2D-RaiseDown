using System;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour {
    [Range(0.25f,5f)]
    public float scaleSpeed;
    public AnimationCurve aCurve;
    private Transform _transform;
    private float step;
    private float objScale;


	// Use this for initialization
	void Start () {
        _transform = this.transform;	
	}
	
	// Update is called once per frame
	void Update () {
        step += scaleSpeed * Time.deltaTime;
        objScale = aCurve.Evaluate(step);
        _transform.localScale = new Vector2(objScale, objScale);
        if (step > 1.5)
            step = 0;
	}
}
