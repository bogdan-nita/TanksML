using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Unity.MLAgents;
using NaughtyAttributes;
using Unity.MLAgents.Extensions.Input;

public class InputActionAssetProvider : MonoBehaviour, IInputActionAssetProvider
{
    [SerializeField]
    protected PlayerInput playerInput = null;

    public (InputActionAsset, IInputActionCollection2) GetInputActionAsset()
    {
        var actions = playerInput.actions;
        return (actions, actions);
    }

    [Button]
    protected virtual void Initialize()
    {
        if (playerInput == null)
        {
            playerInput = GetComponent<PlayerInput>();
        }
    }

    protected virtual void Start()
    {
        Initialize();
    }
}
