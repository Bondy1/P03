using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLevel : MonoBehaviour
{
    [SerializeField] private float _playerLevel = 1;
    [SerializeField] private float _XPToLevel = 50;
    [SerializeField] public float _XPperKill = 25;
    [SerializeField] private GameObject _playerCharacter = null;


    float _totalXP;
    private void Awake()
    {
        _totalXP = 0;
    }


    private void Update()
    {

         if(Keyboard.current.qKey.wasPressedThisFrame)
         {
            _gainXP();
            
         }
        
        if (_totalXP >= _XPToLevel)
        {
            _totalXP = 0;
            _playerLevel += 1;

        }

        if (_playerLevel == 2)
        {
            Debug.Log("level 2");
        }

        if (_playerLevel == 3)
        {
            Debug.Log("level 3");
        }

        if (_playerLevel == 4)
        {
            Debug.Log("level 4");
        }

        if (_playerLevel == 5)
        {
            Debug.Log("level 5");
        }
        
    }

    public void _gainXP()
    {
        _totalXP += _XPperKill;
    }


}
