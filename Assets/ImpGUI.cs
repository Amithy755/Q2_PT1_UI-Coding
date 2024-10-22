using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpGUI : MonoBehaviour
{
    
    public Vector2 position;
    public Vector2 size;

    public string LabelText = "";

    public int Attack = 350;
    public int Defense = 150;
    public int Speed = 100;
    public int Luck = 800;

    public int Attack2 = 300;
    public int Defense2 = 540;
    public int Speed2 = 260;
    public int Luck2 = 95;

    public int Attack3 = 100;
    public int Defense3 = 560;
    public int Speed3 = 88;
    public int Luck3 = 1000;



    private void OnGUI()
    {

        GUI.Box(new Rect(30, 50, 800, 330), "Change Stats");

        if (GUI.Button(new Rect(45, 100, 100, 50), "One"))
        {
            print("One");

            LabelText = "Name: Astrophel\n\rAttack: "+ Attack + "\n\rDefense: "+ Defense + "\n\rSpeed: "+ Speed + "\n\rLuck: "+ Luck ;
        }

        if (GUI.Button(new Rect(45, 200, 100, 50), "Two"))
        {
            print("Two");

            LabelText = "Name: Mirai\n\rAttack2: "+ Attack2 + "\n\rDefense2: "+ Defense2 + "\n\rSpeed2: "+ Speed2 + "\n\rLuck2: "+ Luck2 ;
        }

        if (GUI.Button(new Rect(45, 300, 100, 50), "Three"))
        {
            print("Three");

            LabelText = "Name: Atlas\n\rAttack3: "+ Attack3 + "\n\rDefense3: "+ Defense3 + "\n\rSpeed3: "+ Speed3 + "\n\rLuck3: "+ Luck3 ;
        }

        GUI.Label(new Rect(300, 200, 200, 200), LabelText);

    }

}