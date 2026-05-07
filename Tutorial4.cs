// Under LICENSE: Radioxians OS LICENSE (Open Source) (For more info, view the file LICENSE)

// v 1.0
// You can study, observe, and do whatever you want on this script
// This script is on Git Hub

using UnityEngine;

public class Tutorial4 : MonoBehaviour
{

    public float potenzaSalto = 10;
    public float velocità = 5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("JOINED");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("You are going forward!");
        }
    }
}
