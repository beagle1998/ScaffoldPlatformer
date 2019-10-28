using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    //void Awake()
    //{
    //    Debug.Log("Awake"); //This prints "Awake"
    //}
    // Use this for initialization
    //public string my_string;
    GameObject sprite;
    SpriteRenderer sprite_renderer;
    //string my_str = "Hello World";
    void Start()
    {
        //Debug.Log("Start!"); //This prints "Start!"
        //Debug.Log(my_string);
        //find the sprite
        sprite = GameObject.Find("My Sprite");
        //get the sprute's spriterenderer componenr
        sprite_renderer = sprite.GetComponent<SpriteRenderer>();
        sprite_renderer.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("UPDATE!"); //This prints "UPDATE!"
    }
}
