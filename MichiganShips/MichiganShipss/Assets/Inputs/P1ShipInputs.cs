// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/P1ShipInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @P1ShipInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @P1ShipInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""P1ShipInputs"",
    ""maps"": [
        {
            ""name"": ""PlayerOne"",
            ""id"": ""dc616ed2-2f9e-4f1b-a3e2-914934b82a81"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1ace3c27-9253-4843-a3f2-a383dffd64a2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootStarboard"",
                    ""type"": ""Button"",
                    ""id"": ""43e89fcf-796b-4621-ae84-a95723360cfc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootPort"",
                    ""type"": ""Button"",
                    ""id"": ""90707f87-2160-4bfe-9404-f6a864ba7547"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CursorRight"",
                    ""type"": ""Button"",
                    ""id"": ""0864b2eb-a3dd-4b93-b12e-378d13f7be81"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CursorLeft"",
                    ""type"": ""Button"",
                    ""id"": ""055c6044-48ab-4f5c-8ce5-d9ee651d924d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectCard"",
                    ""type"": ""Button"",
                    ""id"": ""d5b5de95-ff6f-4325-aeec-736738e5d7f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchRow"",
                    ""type"": ""Button"",
                    ""id"": ""183f5f03-1392-4d9e-8d7e-8d026a09abf2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""9ade336f-572d-43f1-bd18-ff857bccf43a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dbd8d649-fab1-494d-8899-d2cda54cac82"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8457d2b8-bb60-4236-91b1-1798e7b84c73"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0df7a710-02be-43ba-a7d9-60b1a44ee5b0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e40501d2-5fae-49fc-8817-00da7ee0c2c0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""377853d2-4bf1-4d7b-94bc-fb4bc42fd870"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootStarboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1eb1b36a-1a23-44ff-b02f-ac46cc6865f9"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootPort"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb96bec3-34ae-4e17-9410-245636055f6e"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CursorLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""206d79c0-d8b3-44d9-93d1-b685e67cf8b6"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CursorRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ad69d27-9750-4a43-b564-362a7d2337bd"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectCard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""057f38de-aa2e-4da3-b3f3-63b1a5fbfa43"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchRow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerOne
        m_PlayerOne = asset.FindActionMap("PlayerOne", throwIfNotFound: true);
        m_PlayerOne_Move = m_PlayerOne.FindAction("Move", throwIfNotFound: true);
        m_PlayerOne_ShootStarboard = m_PlayerOne.FindAction("ShootStarboard", throwIfNotFound: true);
        m_PlayerOne_ShootPort = m_PlayerOne.FindAction("ShootPort", throwIfNotFound: true);
        m_PlayerOne_CursorRight = m_PlayerOne.FindAction("CursorRight", throwIfNotFound: true);
        m_PlayerOne_CursorLeft = m_PlayerOne.FindAction("CursorLeft", throwIfNotFound: true);
        m_PlayerOne_SelectCard = m_PlayerOne.FindAction("SelectCard", throwIfNotFound: true);
        m_PlayerOne_SwitchRow = m_PlayerOne.FindAction("SwitchRow", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // PlayerOne
    private readonly InputActionMap m_PlayerOne;
    private IPlayerOneActions m_PlayerOneActionsCallbackInterface;
    private readonly InputAction m_PlayerOne_Move;
    private readonly InputAction m_PlayerOne_ShootStarboard;
    private readonly InputAction m_PlayerOne_ShootPort;
    private readonly InputAction m_PlayerOne_CursorRight;
    private readonly InputAction m_PlayerOne_CursorLeft;
    private readonly InputAction m_PlayerOne_SelectCard;
    private readonly InputAction m_PlayerOne_SwitchRow;
    public struct PlayerOneActions
    {
        private @P1ShipInputs m_Wrapper;
        public PlayerOneActions(@P1ShipInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerOne_Move;
        public InputAction @ShootStarboard => m_Wrapper.m_PlayerOne_ShootStarboard;
        public InputAction @ShootPort => m_Wrapper.m_PlayerOne_ShootPort;
        public InputAction @CursorRight => m_Wrapper.m_PlayerOne_CursorRight;
        public InputAction @CursorLeft => m_Wrapper.m_PlayerOne_CursorLeft;
        public InputAction @SelectCard => m_Wrapper.m_PlayerOne_SelectCard;
        public InputAction @SwitchRow => m_Wrapper.m_PlayerOne_SwitchRow;
        public InputActionMap Get() { return m_Wrapper.m_PlayerOne; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerOneActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerOneActions instance)
        {
            if (m_Wrapper.m_PlayerOneActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMove;
                @ShootStarboard.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnShootStarboard;
                @ShootStarboard.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnShootStarboard;
                @ShootStarboard.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnShootStarboard;
                @ShootPort.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnShootPort;
                @ShootPort.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnShootPort;
                @ShootPort.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnShootPort;
                @CursorRight.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCursorRight;
                @CursorRight.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCursorRight;
                @CursorRight.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCursorRight;
                @CursorLeft.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCursorLeft;
                @CursorLeft.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCursorLeft;
                @CursorLeft.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCursorLeft;
                @SelectCard.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnSelectCard;
                @SelectCard.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnSelectCard;
                @SelectCard.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnSelectCard;
                @SwitchRow.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnSwitchRow;
                @SwitchRow.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnSwitchRow;
                @SwitchRow.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnSwitchRow;
            }
            m_Wrapper.m_PlayerOneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @ShootStarboard.started += instance.OnShootStarboard;
                @ShootStarboard.performed += instance.OnShootStarboard;
                @ShootStarboard.canceled += instance.OnShootStarboard;
                @ShootPort.started += instance.OnShootPort;
                @ShootPort.performed += instance.OnShootPort;
                @ShootPort.canceled += instance.OnShootPort;
                @CursorRight.started += instance.OnCursorRight;
                @CursorRight.performed += instance.OnCursorRight;
                @CursorRight.canceled += instance.OnCursorRight;
                @CursorLeft.started += instance.OnCursorLeft;
                @CursorLeft.performed += instance.OnCursorLeft;
                @CursorLeft.canceled += instance.OnCursorLeft;
                @SelectCard.started += instance.OnSelectCard;
                @SelectCard.performed += instance.OnSelectCard;
                @SelectCard.canceled += instance.OnSelectCard;
                @SwitchRow.started += instance.OnSwitchRow;
                @SwitchRow.performed += instance.OnSwitchRow;
                @SwitchRow.canceled += instance.OnSwitchRow;
            }
        }
    }
    public PlayerOneActions @PlayerOne => new PlayerOneActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerOneActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShootStarboard(InputAction.CallbackContext context);
        void OnShootPort(InputAction.CallbackContext context);
        void OnCursorRight(InputAction.CallbackContext context);
        void OnCursorLeft(InputAction.CallbackContext context);
        void OnSelectCard(InputAction.CallbackContext context);
        void OnSwitchRow(InputAction.CallbackContext context);
    }
}
