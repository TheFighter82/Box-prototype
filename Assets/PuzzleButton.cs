using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleButton : MonoBehaviour
{
    public float button1;
    public float button2;
    [SerializeField] private float button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(){
        print("inTrigger");
        
            print("boxon");
            if(button == 0){
                
                button1 = 1;
            }   else {
                button2 = 1;
            } 
        
    }
    void OnTriggerExit2D(){
        button1 = 0;
        button2 = 0;
    }
}
