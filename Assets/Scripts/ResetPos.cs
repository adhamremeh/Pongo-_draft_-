using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{

    public GameObject Hand;
    public GameObject Ball;


    // Start is called before the first frame update
    void Start()
    {
        Hand.transform.position = new Vector2(6.56f, 3.75f);
        Ball.transform.position = new Vector2(6.742f, 2.259f);
    }
}
