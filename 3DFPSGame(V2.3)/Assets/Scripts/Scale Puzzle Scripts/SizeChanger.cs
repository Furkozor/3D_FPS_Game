using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    public float growScale = 1.5f; //büyüme katsayýsý
    public float shrinkScale = 0.5f; //küçülme katsayýsý

    private Vector3 originalScale; // orijinal boyut
    private bool isGrown = false; //karakterin büyük mü kontrol eder
    private bool isShrunk = false; // karakter küçük mü kontrol eder
    private bool isOriginal = true; //karakter orijinal boyutta mý kontrol eder


    // Start is called before the first frame update
    void Start()
    {
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isShrunk)
        {
            Shrink();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Grow();
        }
    }

    private void Shrink()
    {
        if (isOriginal)
        {
            transform.localScale *= shrinkScale; // shrink

            isShrunk = true;
            isOriginal = false;
        }
        else if (isGrown)
        {
            transform.localScale *= shrinkScale;

            isGrown = false;
            isOriginal = true;
        }
    }

    private void Grow()
    {
        if (isOriginal)
        {
            transform.localScale *= growScale; // Grow

            isGrown = true;
            isOriginal = false;
        }
        else if (isShrunk)
        {
            transform.localScale *= growScale;

            isShrunk = false;
            isOriginal = true;
        }
    }
}
