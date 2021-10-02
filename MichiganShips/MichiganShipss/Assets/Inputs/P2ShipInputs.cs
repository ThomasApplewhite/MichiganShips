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
                }
            ]
        },
        {
            ""name"": ""UITwo"",
            ""id"": ""c1b6b68e-e832-482f-beb2-aea5316439e7"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""66540019-4bd2-4c42-b79b-fbac5d2efcea"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e2891b52-8fc5-4b87-86b5-b8ff752a2583"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""6e268ef6-ee31-4443-b911-ec253298f67f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f4420f1a-f456-47ef-9000-8a68585f0842"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ac47ccb-478a-4902-ac9f-ff5ac82a4825"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""JL"",
                    ""id"": ""8c743a72-3cf8-4821-82b9-a086284eea8d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""cb329c4d-e7d0-449a-9438-ae5350df7a42"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""8796b998-74c2-42d0-ab04-68b858eeae0f"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
        // UITwo
        m_UITwo = asset.FindActionMap("UITwo", throwIfNotFound: true);
        m_UITwo_Navigate = m_UITwo.FindAction("Navigate", throwIfNotFound: true);
        m_UITwo_Submit = m_UITwo.FindAction("Submit", throwIfNotFound: true);
        m_UITwo_Cancel = m_UITwo.FindAction("Cancel", throwIfNotFound: true);
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
    public struct PlayerTwoActions
    {
        private @P2ShipInputs m_Wrapper;
        public PlayerTwoActions(@P2ShipInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerTwo_Move;
        public InputAction @ShootStarboard => m_Wrapper.m_PlayerTwo_ShootStarboard;
        public InputAction @ShootPort => m_Wrapper.m_PlayerTwo_ShootPort;
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
            }
        }
    }
    public PlayerTwoActions @PlayerTwo => new PlayerTwoActions(this);

    // UITwo
    private readonly InputActionMap m_UITwo;
    private IUITwoActions m_UITwoActionsCallbackInterface;
    private readonly InputAction m_UITwo_Navigate;
    private readonly InputAction m_UITwo_Submit;
    private readonly InputAction m_UITwo_Cancel;
    public struct UITwoActions
    {
        private @P2ShipInputs m_Wrapper;
        public UITwoActions(@P2ShipInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_UITwo_Navigate;
        public InputAction @Submit => m_Wrapper.m_UITwo_Submit;
        public InputAction @Cancel => m_Wrapper.m_UITwo_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_UITwo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UITwoActions set) { return set.Get(); }
        public void SetCallbacks(IUITwoActions instance)
        {
            if (m_Wrapper.m_UITwoActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_UITwoActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UITwoActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UITwoActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_UITwoActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UITwoActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UITwoActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_UITwoActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UITwoActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UITwoActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_UITwoActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public UITwoActions @UITwo => new UITwoActions(this);
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
    }
    public interface IUITwoActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
