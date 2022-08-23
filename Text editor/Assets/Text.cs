using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class Text : MonoBehaviour
{
    void Update()
    {
        //Write
        if (Input.GetMouseButtonDown(0))
        {
            StreamWriter writer = new StreamWriter("Assets/txt.txt", true);



            //Write lines here, this writes test on the next line consecutively
            writer.WriteLine("Test");




            writer.Close();
        }
        if (Input.GetMouseButtonDown(1))
        {
            StreamReader reader = new StreamReader("Assets/txt.txt");



            //Read lines here, this reads the first line entirely
            Debug.Log(reader.ReadToEnd());




            reader.Close();
        }
    }

}
