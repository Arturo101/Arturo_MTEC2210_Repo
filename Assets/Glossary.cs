using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glossary : MonoBehaviour
{
    public GameObject teacher;
    private Sprite teacherSprite;
    private Color teacherColor;
    

    // Start is called before the first frame update
    void Start()
    {
        teacherColor = GameObject.Find("Beard").GetComponent<SpriteRenderer>().color;
        // for the beard
        GameObject.Find("Beard").GetComponent<SpriteRenderer>().color = Color.red;
        //hair color
        GameObject.Find("Hair").GetComponent<SpriteRenderer>().color = Color.cyan;
        //face color
        GameObject.Find("Face").GetComponent<SpriteRenderer>().color = Color.green;
       // teacherSprite = teacher.GetComponent<SpriteRenderer>().sprite;
        
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
