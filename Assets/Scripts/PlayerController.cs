using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] private float _speed = 5.0f;
  //  [SerializeField] private float _jump = 10.0f;
    private Vector3 velocity;
    private Vector3 move;
    private CharacterController characterController;
    private bool _isGrounded;
    private float _currentposition;


    void Start()
    {
        characterController = gameObject.AddComponent<CharacterController>();
        _currentposition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 positionY = transform.position;
        positionY.y = _currentposition;
        // transform.position = positionY;
        _isGrounded = characterController.isGrounded;
        if (_isGrounded && velocity.y < 0)
        {
            velocity.y = 0;
        }

        float movementX = Input.GetAxis("Horizontal");
        float movementZ = Input.GetAxis("Vertical");
        move = new Vector3(movementX, 0,movementZ);
        
        if(move.magnitude >= 0.1f)
        {
            characterController.Move(move* Time.deltaTime* _speed);
            
        //     Vector3 direction = new Vector3(movementX, 0, movementZ).normalized; 
        //     // Quaternion rotation = 
        //     // transform.rotation = Quaternion.Slerp(transform.rotation, )
        }
        // transform.position = positionY;
    }
}
