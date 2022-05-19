using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    Camera _mainCam;
    Ray _ray;
    RaycastHit _hit;

    void Start()
    {
        _mainCam = Camera.main;
    }

    void Update()
    {
        MouseInput();
    }
    public Transform testCube;
    void MouseInput()
    {
        _ray = _mainCam.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(_ray, out _hit))
        {
            testCube.position = _hit.point;
        }
    }
}
