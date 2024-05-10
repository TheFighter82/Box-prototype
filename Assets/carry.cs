using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class carry : MonoBehaviour
{
    [SerializeField] GameObject Carrypoint;
    [SerializeField] GameObject Player;
    [SerializeField] float Speed;
    public GameObject playerObj;
    public float movement;
    private float carryx;
    private float carryy;
    // Start is called before the first frame update
    void Start()
    {
        movement = Player.GetComponent<PhysicalCharacterController2D>().moveSpeed;
        playerObj = Player.GetComponent<PhysicalCharacterController2D>().SetSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        carryx = Carrypoint.transform.position.x;
        carryy = Carrypoint.transform.position.y;
    }
    void OnTriggerStay2D(){
        playerObj = this.GameObject();
        print("In Range");
        if(Input.GetKey(KeyCode.X)){
        transform.position = new Vector2(carryx, carryy);
        movement = Speed;
        
        
        } else{
            movement = 6f;
        }
    }
}
