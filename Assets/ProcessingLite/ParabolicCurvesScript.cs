using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicCurvesScript : ProcessingLite.GP21
{

    public int lineAmount;
    private float spaceBetweenLines;


    private void Start()
    {
        Application.targetFrameRate = 5;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i < lineAmount + 1; i++)
        {
            spaceBetweenLines = Height / lineAmount;
            float y = Height;

            if (i % 3 == 0)
            {
                Stroke(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
            }
            else
            {
                Stroke(255);
            }

            Line(0, y - i * spaceBetweenLines, 0 + i * spaceBetweenLines, 0);
            Debug.Log(i);

        }

        //CreateParabolicCurve(, lineAmount);
    }



    //private void CreateParabolicCurve(Vector2 axis1Start, Vector2 axis1End, Vector2 axis2Start, Vector2 axis2End, int numberOfLines)
    //{
    //    for (int i = 1; i < lineAmount + 1; i++)
    //    {
    //        spaceBetweenLines = Height / lineAmount;
    //        float y = Height;

    //        Line(axis1Start.x, axis1Start.y - i * spaceBetweenLines, axis1End.x + i * spaceBetweenLines, axis1End.y);
    //        //Debug.Log(i);

    //    }
    //}
}
