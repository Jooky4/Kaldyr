using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FrontCollider : MonoBehaviour
{
    [SerializeField]
    private GameObject mainCamera;
    private CameraManager cameraManager;

    // Start is called before the first frame update
    void Start()
    {
        cameraManager = mainCamera.GetComponent<CameraManager>();
       // oldSpeedMoveCamera = cameraManager.stepMoveCamera;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Front Enter Player");
            //cameraManager.stepMoveCamera += stepAccelerationCamera;
            cameraManager.IsAccelerationCamera = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Front Exit Player");
            //cameraManager.stepMoveCamera = oldSpeedMoveCamera;
            cameraManager.IsAccelerationCamera = false;

        }

    }
}
