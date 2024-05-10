using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSolve : MonoBehaviour
{
    [SerializeField] GameObject but1;
    [SerializeField] GameObject but2;
    [SerializeField] float switch1;
    [SerializeField] float switch2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch1 = but1.GetComponent<PuzzleButton>().button1;
        switch2 = but2.GetComponent<PuzzleButton>().button2;
        if (switch1 == 1 && switch2 == 1){
            print("solved");
            GetComponent<SpriteRenderer>().color = Color.green;

        }
    }
}
