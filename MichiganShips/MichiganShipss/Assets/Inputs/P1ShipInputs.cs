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
                }
            ]
        },
        {
            ""name"": ""UIOne"",
            ""id"": ""49df0de1-82bf-46f3-9015-72f2204184a7"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""47dd4522-a5a7-4f68-90ed-34bd304b38b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e6c3adb2-76d9-4956-ab57-6b7c5bf852df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""927cc48a-d422-493d-9dc7-9acaaddc0db1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3d19e5b7-1f40-46fb-bdc9-78e950923f9d"",
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
                    ""id"": ""d4bee855-616e-46ab-b104-8746bb676ec9"",
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
                    ""id"": ""2510c44e-4e36-4c67-bd7b-5bacb69401d3"",
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
                    ""id"": ""f5a1e31b-8a77-45c0-9411-98178c5294d1"",
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
                    ""id"": ""623001c9-0967-4db5-8907-2f35a9a82c0c"",
                    ""path"": ""<Keyboard>/b"",
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
        // PlayerOne
        m_PlayerOne = asset.FindActionMap("PlayerOne", throwIfNotFound: true);
        m_PlayerOne_Move = m_PlayerOne.FindAction("Move", throwIfNotFound: true);
        m_PlayerOne_ShootStarboard = m_PlayerOne.FindAction("ShootStarboard", throwIfNotFound: true);
        m_PlayerOne_ShootPort = m_PlayerOne.FindAction("ShootPort", throwIfNotFound: true);
        // UIOne
        m_UIOne = asset.FindActionMap("UIOne", throwIfNotFound: true);
        m_UIOne_Navigate = m_UIOne.FindAction("Navigate", throwIfNotFound: true);
        m_UIOne_Submit = m_UIOne.FindAction("Submit", throwIfNotFound: true);
        m_UIOne_Cancel = m_UIOne.FindAction("Cancel", throwIfNotFound: true);
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
        private @P1ShipInputs m_Wrapper;
        public PlayerOneActions(@P1ShipInputs wrapper) { m_Wrapper = wrapper; }
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

    // UIOne
    private readonly InputActionMap m_UIOne;
    private IUIOneActions m_UIOneActionsCallbackInterface;
    private readonly InputAction m_UIOne_Navigate;
    private readonly InputAction m_UIOne_Submit;
    private readonly InputAction m_UIOne_Cancel;
    public struct UIOneActions
    {
        private @P1ShipInputs m_Wrapper;
        public UIOneActions(@P1ShipInputs wrapper) { m_Wrapper = wrapper; }
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
    }
    public interface IUIOneActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
