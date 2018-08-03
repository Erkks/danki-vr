using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stripColour : MonoBehaviour {

    //public Color color1 = Color.blue;
    //public Color color2 = Color.red;
    //public float duration = 10.0F;
	public Renderer rend;

    public Gradient myGradient;
    public float strobeDuration = 100F;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        //float lerp = Mathf.PingPong(Time.time, duration) / duration;
        //rend.material.color = Color.Lerp(color1, color2, lerp);

        //float t = Mathf.PingPong(Time.time / strobeDuration, 1f);
        float t = Mathf.PingPong(Time.time, strobeDuration) / strobeDuration;
        rend.material.color = myGradient.Evaluate(t);
    }
}
