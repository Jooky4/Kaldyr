using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform startPosition;
    [SerializeField]
    private Transform endPosition;
    [SerializeField]
    [Header ("Скорость камеры")]
    private float stepMoveCamera = 1;
    [SerializeField]
    [Header("Ускорение камеры")]
    private float stepAccelerationCamera = 5.0f;
    private float speedMove;
    private float distanceDelta;
    [SerializeField]
    private float positionCameraZ = -10f;
    [SerializeField]
    private float positionCameraY = 30f;
    public bool isMoveCamera = true;
    public bool IsAccelerationCamera = false;


    void Start()
    {

        transform.position = new Vector3(startPosition.transform.position.x, positionCameraY, positionCameraZ);
        //isMoveCamera = false;
    }

    void Update()
    {

        if (isMoveCamera)
        {
            distanceDelta = speedMove * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, endPosition.position, distanceDelta);
            transform.position = new Vector3(transform.position.x, positionCameraY, positionCameraZ);
        }

        if (IsAccelerationCamera)
        {
            speedMove = stepMoveCamera + stepAccelerationCamera;
        }
        else
        {
            speedMove = stepMoveCamera;
        }
       
    }
}
