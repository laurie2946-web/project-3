using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string name= "Laurie";
    // Start is called before the first frame update
    bool answer1 = true && true;
    void Start()
    {
       Debug.Log(answer1);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello!" + name);
    }
    
  //  Debug.Log("FOLLOW THE HUMAN");
    //Dog.position = Vector3.MoveTowards(Dog.position, Human, Distance);
}
