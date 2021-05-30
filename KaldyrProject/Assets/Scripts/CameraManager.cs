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
    [Header ("Начальная скорость камеры")]
    private float beginSpeedCamera = 1f;

    [SerializeField]
    [Header("Таймер ускорения камеры")]
    private float timerAccelerateCamera = 1f;

    [Header("Шаг ускорения камеры")]
    [SerializeField]
    private float stepAccelerateCamera = 1f;

    [Header("Шаг времени ускорения камеры")]
    [SerializeField]
    private float stepTimerAccelerateCamera = 1f;

    //[SerializeField]
    //[Header("Ускорение камеры")]
    private float stepAccelerationCamera = 5.0f;

    [Header("Max скорость камеры")]
    [SerializeField]
    private float maxSpeedCamera = 10f;

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
        speedMoveOld = beginSpeedCamera;
        speedMove = 0;
        InvokeRepeating("TimerAccelerateCamera", timerAccelerateCamera, stepTimerAccelerateCamera);
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
           speedMove = speedMoveOld + stepAccelerationCamera;
        }
        else
        {
             speedMove = speedMoveOld;
        }
    }
   
    void TimerAccelerateCamera()
    {
        speedMoveOld = speedMoveOld + beginSpeedCamera * stepAccelerateCamera; //* 0.002f;
        speedMoveOld = Mathf.Clamp(speedMoveOld, 0, maxSpeedCamera);
    }


}
