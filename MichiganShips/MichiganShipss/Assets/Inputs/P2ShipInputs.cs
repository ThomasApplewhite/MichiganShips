// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/P2ShipInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @P2ShipInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @P2ShipInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""P2ShipInputs"",
    ""maps"": [
        {
            ""name"": ""PlayerTwo"",
            ""id"": ""320df695-edf9-4cb9-8ee6-3ceeae04593f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""2c73e169-4be4-48b5-8baa-15ee9ad4601a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootStarboard"",
                    ""type"": ""Button"",
                    ""id"": ""2a395a05-bc28-4db4-a084-faba7ae18d6e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootPort"",
                    ""type"": ""Button"",
                    ""id"": ""38dd631d-ff3f-424a-996d-ab72e3294aa0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CursorLeft"",
                    ""type"": ""Button"",
                    ""id"": ""add2da7d-a315-47e9-932d-b8a5f3e832bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CursorRight"",
                    ""type"": ""Button"",
                    ""id"": ""05d1c3c4-6606-4342-87c0-b7eba9281c02"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectCard"",
                    ""type"": ""Button"",
                    ""id"": ""c20e0664-ec3f-4801-a78b-43337ecc7485"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchRow"",
                    ""type"": ""Button"",
                    ""id"": ""30b6864e-d449-4424-9f4d-c208e62e6802"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""db5f1081-5769-46e9-823b-312513b47b60"",
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
                    ""id"": ""36789b99-88c7-495e-829f-3a998214e0e8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""51b0eb4f-6441-4317-8d36-23b0b0d1665d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8ba1df3c-1912-423d-87af-54e06f4f0f4c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""336616fe-871a-4d8c-ab34-d2e00ccea16c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e6976fa5-309c-4bbf-9015-4bbffb23876a"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootStarboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78f715f7-4774-4430-84fa-686c7c99201d"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootPort"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a1d95b6-9ca6-4131-b177-d4612db16960"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CursorLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c68336c-71e3-4995-b430-10c02bbaa2ee"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CursorRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8285584a-e903-4ca9-92c4-edccca8c103a"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectCard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d817c3e-6098-47ee-a18b-f250d3a6da22"",
                    ""path"": ""<Keyboard>/k"",
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
        // PlayerTwo
        m_PlayerTwo = asset.FindActionMap("PlayerTwo", throwIfNotFound: true);
        m_PlayerTwo_Move = m_PlayerTwo.FindAction("Move", throwIfNotFound: true);
        m_PlayerTwo_ShootStarboard = m_PlayerTwo.FindAction("ShootStarboard", throwIfNotFound: true);
        m_PlayerTwo_ShootPort = m_PlayerTwo.FindAction("ShootPort", throwIfNotFound: true);
        m_PlayerTwo_CursorLeft = m_PlayerTwo.FindAction("CursorLeft", throwIfNotFound: true);
        m_PlayerTwo_CursorRight = m_PlayerTwo.FindAction("CursorRight", throwIfNotFound: true);
        m_PlayerTwo_SelectCard = m_PlayerTwo.FindAction("SelectCard", throwIfNotFound: true);
        m_PlayerTwo_SwitchRow = m_PlayerTwo.FindAction("SwitchRow", throwIfNotFound: true);
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

    // PlayerTwo
    private readonly InputActionMap m_PlayerTwo;
    private IPlayerTwoActions m_PlayerTwoActionsCallbackInterface;
    private readonly InputAction m_PlayerTwo_Move;
    private readonly InputAction m_PlayerTwo_ShootStarboard;
    private readonly InputAction m_PlayerTwo_ShootPort;
    private readonly InputAction m_PlayerTwo_CursorLeft;
    private readonly InputAction m_PlayerTwo_CursorRight;
    private readonly InputAction m_PlayerTwo_SelectCard;
    private readonly InputAction m_PlayerTwo_SwitchRow;
    public struct PlayerTwoActions
    {
        private @P2ShipInputs m_Wrapper;
        public PlayerTwoActions(@P2ShipInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerTwo_Move;
        public InputAction @ShootStarboard => m_Wrapper.m_PlayerTwo_ShootStarboard;
        public InputAction @ShootPort => m_Wrapper.m_PlayerTwo_ShootPort;
        public InputAction @CursorLeft => m_Wrapper.m_PlayerTwo_CursorLeft;
        public InputAction @CursorRight => m_Wrapper.m_PlayerTwo_CursorRight;
        public InputAction @SelectCard => m_Wrapper.m_PlayerTwo_SelectCard;
        public InputAction @SwitchRow => m_Wrapper.m_PlayerTwo_SwitchRow;
        public InputActionMap Get() { return m_Wrapper.m_PlayerTwo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerTwoActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerTwoActions instance)
        {
            if (m_Wrapper.m_PlayerTwoActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnMove;
                @ShootStarboard.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnShootStarboard;
                @ShootStarboard.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnShootStarboard;
                @ShootStarboard.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnShootStarboard;
                @ShootPort.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnShootPort;
                @ShootPort.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnShootPort;
                @ShootPort.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnShootPort;
                @CursorLeft.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCursorLeft;
                @CursorLeft.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCursorLeft;
                @CursorLeft.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCursorLeft;
                @CursorRight.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCursorRight;
                @CursorRight.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCursorRight;
                @CursorRight.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCursorRight;
                @SelectCard.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnSelectCard;
                @SelectCard.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnSelectCard;
                @SelectCard.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnSelectCard;
                @SwitchRow.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnSwitchRow;
                @SwitchRow.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnSwitchRow;
                @SwitchRow.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnSwitchRow;
            }
            m_Wrapper.m_PlayerTwoActionsCallbackInterface = instance;
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
                @CursorLeft.started += instance.OnCursorLeft;
                @CursorLeft.performed += instance.OnCursorLeft;
                @CursorLeft.canceled += instance.OnCursorLeft;
                @CursorRight.started += instance.OnCursorRight;
                @CursorRight.performed += instance.OnCursorRight;
                @CursorRight.canceled += instance.OnCursorRight;
                @SelectCard.started += instance.OnSelectCard;
                @SelectCard.performed += instance.OnSelectCard;
                @SelectCard.canceled += instance.OnSelectCard;
                @SwitchRow.started += instance.OnSwitchRow;
                @SwitchRow.performed += instance.OnSwitchRow;
                @SwitchRow.canceled += instance.OnSwitchRow;
            }
        }
    }
    public PlayerTwoActions @PlayerTwo => new PlayerTwoActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerTwoActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShootStarboard(InputAction.CallbackContext context);
        void OnShootPort(InputAction.CallbackContext context);
        void OnCursorLeft(InputAction.CallbackContext context);
        void OnCursorRight(InputAction.CallbackContext context);
        void OnSelectCard(InputAction.CallbackContext context);
        void OnSwitchRow(InputAction.CallbackContext context);
    }
}
