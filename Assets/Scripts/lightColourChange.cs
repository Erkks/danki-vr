using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightColourChange : MonoBehaviour {

	//public Color color1 = Color.red;
    //public Color color2 = Color.blue;
    //public float duration = 10.0F;

    public Gradient myGradient;
    public float strobeDuration = 100F;

    public Light light;

    void Start()
    {
        light = GetComponent<Light>();
    }

    void Update()
    {
        //float t = Mathf.PingPong(Time.time, duration) / duration;
        //cam.backgroundColor = Color.Lerp(color1, color2, t);

        float t = Mathf.PingPong(Time.time, strobeDuration) / strobeDuration;
        light.color = myGradient.Evaluate(t);
    }
}
