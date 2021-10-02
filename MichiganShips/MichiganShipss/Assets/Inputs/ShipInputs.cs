// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/ShipInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ShipInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ShipInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ShipInputs"",
    ""maps"": [
        {
            ""name"": ""PlayerOne"",
            ""id"": ""01e190fb-fd74-421c-85eb-bce89c85f7b6"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""afb3aabf-a22d-4e05-9f0e-9cac5563675c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootStarboard"",
                    ""type"": ""Button"",
                    ""id"": ""94e00dc0-9507-48c2-a577-ffc5dfbebcae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootPort"",
                    ""type"": ""Button"",
                    ""id"": ""927bfa92-1818-4a64-b964-75ce4ee92e1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""28254d27-f985-4a89-b001-f995942154fe"",
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
                    ""id"": ""f8a17391-1000-40c1-97d2-1f02841800d5"",
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
                    ""id"": ""a8727521-806e-4ef6-be53-7828014de268"",
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
                    ""id"": ""f2d30b68-47d0-44ed-bc59-025e1faf7159"",
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
                    ""id"": ""48c3b2ac-33ea-43c0-b027-c5e5302b3d18"",
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
                    ""id"": ""5f2907ce-cc2d-4706-a57d-f389607463a8"",
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
                    ""id"": ""e3043684-cabc-4d33-92a9-06cdd20bca15"",
                    ""path"": ""<Keyboard>/q"",
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
            ""name"": ""PlayerTwo"",
            ""id"": ""23a51202-07db-47ab-99ce-f74ab0801d18"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""6495ea51-6c1f-4290-9dd9-d95bcae0bb11"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootStarboard"",
                    ""type"": ""Button"",
                    ""id"": ""886c041a-1d5e-4ec9-875e-12a324a1e30d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootPort"",
                    ""type"": ""Button"",
                    ""id"": ""d6dd1ee7-9eb8-4cd8-b2ab-08eb58469a50"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""25ba73b3-aa23-47c5-8d0d-a20dd2f371b5"",
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
                    ""id"": ""6ae24c97-0443-4940-9d92-2e776b91b3fb"",
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
                    ""id"": ""8430c5bd-dfb6-4687-ac83-596631d84646"",
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
                    ""id"": ""c05c20c3-3628-4083-8ea8-108ecf58b67d"",
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
                    ""id"": ""e79a4dd7-cab6-41e2-a719-a73e2437ad23"",
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
                    ""id"": ""2dab35ee-44b1-41df-a2cb-4e78109b109d"",
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
                    ""id"": ""b9ffff41-6c56-4ff3-86f1-1c9dbde82001"",
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
            ""name"": ""UIOne"",
            ""id"": ""3475e543-92bd-4915-b6fa-761fc2358a6d"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Button"",
                    ""id"": ""e662e430-2bed-4e88-86f3-06f9c966374f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""e5d6f6f7-d9b4-4423-9f4c-fbc1460ccca5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""52f716e2-8e11-4436-8c72-991a8d867d23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9e92bb26-7e3b-4ec4-b06b-3c8f8e498ddc"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82627dcc-3b13-4ba9-841d-e4b746d6553e"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""CB"",
                    ""id"": ""64d193cd-7440-43ca-9bad-e4d0fb7b1917"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a44fe37d-f69b-4b35-a86f-6024ef634be8"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5882e4da-d7e2-4047-aa30-f2689eb481c2"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""UITwo"",
            ""id"": ""d07b44f8-6da2-4531-815a-f7884b626276"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Button"",
                    ""id"": ""0ebfeafc-f7e6-42a2-98ca-20c86caa5440"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""c79ede63-2280-499d-b3e0-b368cd9007f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""cdfa3ce1-b170-4f0e-b09c-a886879f87a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f6be470d-2666-4c0c-9f33-e0f3ae5c28f0"",
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
                    ""id"": ""0ce4e8be-615a-47fe-a0da-052f1fb12ff0"",
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
                    ""id"": ""3983971a-562a-4196-a9e2-7f35d4fc7fa9"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a0849397-f4c9-493e-8324-e14ddaa5c28b"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6b78aa9e-d0a8-4ac1-a569-3b884068bbf4"",
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
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
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
        // PlayerTwo
        m_PlayerTwo = asset.FindActionMap("PlayerTwo", throwIfNotFound: true);
        m_PlayerTwo_Move = m_PlayerTwo.FindAction("Move", throwIfNotFound: true);
        m_PlayerTwo_ShootStarboard = m_PlayerTwo.FindAction("ShootStarboard", throwIfNotFound: true);
        m_PlayerTwo_ShootPort = m_PlayerTwo.FindAction("ShootPort", throwIfNotFound: true);
        // UIOne
        m_UIOne = asset.FindActionMap("UIOne", throwIfNotFound: true);
        m_UIOne_Navigate = m_UIOne.FindAction("Navigate", throwIfNotFound: true);
        m_UIOne_Submit = m_UIOne.FindAction("Submit", throwIfNotFound: true);
        m_UIOne_Cancel = m_UIOne.FindAction("Cancel", throwIfNotFound: true);
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

    // PlayerOne
    private readonly InputActionMap m_PlayerOne;
    private IPlayerOneActions m_PlayerOneActionsCallbackInterface;
    private readonly InputAction m_PlayerOne_Move;
    private readonly InputAction m_PlayerOne_ShootStarboard;
    private readonly InputAction m_PlayerOne_ShootPort;
    public struct PlayerOneActions
    {
        private @ShipInputs m_Wrapper;
        public PlayerOneActions(@ShipInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerOne_Move;
        public InputAction @ShootStarboard => m_Wrapper.m_PlayerOne_ShootStarboard;
        public InputAction @ShootPort => m_Wrapper.m_PlayerOne_ShootPort;
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
            }
        }
    }
    public PlayerOneActions @PlayerOne => new PlayerOneActions(this);

    // PlayerTwo
    private readonly InputActionMap m_PlayerTwo;
    private IPlayerTwoActions m_PlayerTwoActionsCallbackInterface;
    private readonly InputAction m_PlayerTwo_Move;
    private readonly InputAction m_PlayerTwo_ShootStarboard;
    private readonly InputAction m_PlayerTwo_ShootPort;
    public struct PlayerTwoActions
    {
        private @ShipInputs m_Wrapper;
        public PlayerTwoActions(@ShipInputs wrapper) { m_Wrapper = wrapper; }
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

    // UIOne
    private readonly InputActionMap m_UIOne;
    private IUIOneActions m_UIOneActionsCallbackInterface;
    private readonly InputAction m_UIOne_Navigate;
    private readonly InputAction m_UIOne_Submit;
    private readonly InputAction m_UIOne_Cancel;
    public struct UIOneActions
    {
        private @ShipInputs m_Wrapper;
        public UIOneActions(@ShipInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_UIOne_Navigate;
        public InputAction @Submit => m_Wrapper.m_UIOne_Submit;
        public InputAction @Cancel => m_Wrapper.m_UIOne_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_UIOne; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIOneActions set) { return set.Get(); }
        public void SetCallbacks(IUIOneActions instance)
        {
            if (m_Wrapper.m_UIOneActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_UIOneActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIOneActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIOneActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_UIOneActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIOneActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIOneActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_UIOneActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIOneActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIOneActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_UIOneActionsCallbackInterface = instance;
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
    public UIOneActions @UIOne => new UIOneActions(this);

    // UITwo
    private readonly InputActionMap m_UITwo;
    private IUITwoActions m_UITwoActionsCallbackInterface;
    private readonly InputAction m_UITwo_Navigate;
    private readonly InputAction m_UITwo_Submit;
    private readonly InputAction m_UITwo_Cancel;
    public struct UITwoActions
    {
        private @ShipInputs m_Wrapper;
        public UITwoActions(@ShipInputs wrapper) { m_Wrapper = wrapper; }
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
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlayerOneActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShootStarboard(InputAction.CallbackContext context);
        void OnShootPort(InputAction.CallbackContext context);
    }
    public interface IPlayerTwoActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShootStarboard(InputAction.CallbackContext context);
        void OnShootPort(InputAction.CallbackContext context);
    }
    public interface IUIOneActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
    public interface IUITwoActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
