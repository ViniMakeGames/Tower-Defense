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
        CursorPositionUpdate();
        MouseInput();
    }

    Vector3 _cursorPosition;
    Transform _hoveredObject;
    void CursorPositionUpdate()
    {
        _ray = _mainCam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(_ray, out _hit))
        {
            _cursorPosition = _hit.point;
            _hoveredObject = _hit.transform;
        }
    }

    int _selectedTower = -1;
    void MouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(_selectedTower > -1 && _hoveredObject.tag == "TowerSlot" && _hoveredObject.childCount == 1)
            {
                //Instantiate tower
            }
        }
    }
}
