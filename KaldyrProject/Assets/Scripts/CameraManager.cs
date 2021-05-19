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
    private float speedMoveCamera = 1;
    [Header("Шаг увеличения скорости камеры")]
    [SerializeField]
    [Range(1, 10)]
    private float stepSpeedCamera;
    [SerializeField]
    [Header("Ускорение камеры")]
    private float stepAccelerationCamera = 5.0f;
    [Header("Max скорость камеры")]
    [SerializeField]
    [Range(1, 50)]
    private float maxSpeedCamera;
    [SerializeField]
    private float speedMove;
    private float speedMoveOld;
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
        speedMoveOld = 0;
        speedMove =0;

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
            speedMoveOld = speedMove;
            speedMove = speedMove + stepAccelerationCamera;

            // speedMove = speedMoveCamera + stepAccelerationCamera;
        }
        else
        {
            speedMove += speedMoveCamera * stepSpeedCamera * 0.005f;
            //speedMove = speedMoveOld;
            speedMove = Mathf.Clamp(speedMove, 0, maxSpeedCamera);
            //speedMove = speedMoveOld;
            //speedMove = speedMoveCamera;
        }

        

    }
    private void FixedUpdate()
    {
       
    }


}
