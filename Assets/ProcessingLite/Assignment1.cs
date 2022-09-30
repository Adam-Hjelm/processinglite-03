using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : ProcessingLite.GP21
{
    public int aposX;
    public int aposY;

    [Space]

    public float x;
    public float y;
    public float diameter = 0.2f;

    [Space]

    public float spaceBetweenLines = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        CreateA(aposX, aposY);


        //Creates d
        Line(7, 7, 7, 2);
        NoFill();
        Circle(6, 3, 2);

        //Creates a
        Line(9.5f, 3.5f, 9.5f, 2);
        NoFill();
        Circle(8.5f, 3, 2);

        //Creates m
        Line(10, 4, 10, 2);
        Fill(0, 0, 0);
        Ellipse(11, 2, 2, 4);
        Ellipse(13, 2, 2, 4);
        Stroke(0);
        Rect(10, 2, 14, 0);

    }

    private void CreateA(int aposX, int aposY)
    {
        // Creates A
        Line(4, 7, 3, 2);
        Line(4, 7, 5, 2);
        Line(3.4f, 4, 4.6f, 4);
    }

    // Update is called once per frame
    void Update()
    {
        //Clear background
        //Background(50, 166, 240);

        //Draw our art/stuff, or in this case a rectangle
        Stroke(255);
        Fill(25, 25, 255);
        Rect(1, 1, 3, 3);
        Fill(255, 25, 25);
        Ellipse(12, 9, 3, 6);

        //Prepare our stroke settings
        Stroke(128, 128, 128, 64);
        StrokeWeight(0.5f);

        //Draw our scan lines
        for (int i = 0; i < Height / spaceBetweenLines; i++)
        {
            //Increase y-cord each time loop run
            float y = i * spaceBetweenLines;

            //Draw a line from left side of screen to the right
            Line(0, y, Width, y);
        }


        //Background(0); //Clears the background and sets the color to 0.
        //Circle(x, y, diameter); //Draws a circle on screen.
    }
}
