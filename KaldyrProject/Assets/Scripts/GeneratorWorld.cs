using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorWorld : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabBlock;
    [SerializeField]
    private Transform startGeneration;
    [SerializeField]
    private Transform endGeneration;
    [SerializeField]
    private bool isGeneration = true;
    private Transform tempScale;



    // Start is called before the first frame update
    void Start()
    {

        tempScale = prefabBlock.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
