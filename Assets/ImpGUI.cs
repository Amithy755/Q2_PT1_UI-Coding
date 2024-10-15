using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpGUI : MonoBehaviour
{
    
    public Vector2 position;
    public Vector2 size;

    public string LabelText = "";

    private void OnGUI()
    {

        GUI.Box(new Rect(30, 50, 800, 330), "Change Stats");

        if (GUI.Button(new Rect(45, 100, 100, 50), "One"))
        {
            print("One");

            LabelText = "Name: Astrophel\n\rAttack: 800\n\rDefense: 95\n\rSpeed:50\n\rLuck: 250";
        }

        if (GUI.Button(new Rect(45, 200, 100, 50), "Two"))
        {
            print("Two");

            LabelText = "Name: Mirai\n\rAttack: 300\n\rDefense: 540\n\rSpeed:80\n\rLuck:30";
        }

        if (GUI.Button(new Rect(45, 300, 100, 50), "Three"))
        {
            print("Three");

            LabelText = "Name: Atlas\n\rAttack: 100\n\rDefense: 560\n\rSpeed:88\n\rLuck:1000";
        }

        GUI.Label(new Rect(300, 200, 200, 200), LabelText);

    }

}