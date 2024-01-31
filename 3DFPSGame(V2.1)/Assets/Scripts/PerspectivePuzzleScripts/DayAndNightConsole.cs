using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class DayAndNightConsole : MonoBehaviour
{
    [Header("Sun of the Scene")]
    public DirectionalLight DirectionalLight;
    [SerializeField] private float xRotationOfTheSun;
    [SerializeField] private float yRotationOfTheSun;

    // Start is called before the first frame update
    void Start()
    {
        //xRotationOfTheSun = ;
        //yRotationOfTheSun = ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
