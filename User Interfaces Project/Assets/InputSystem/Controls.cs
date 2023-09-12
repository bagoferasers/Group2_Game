//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/InputSystem/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""b71105c8-281f-4572-98d7-fa1adc1a23b6"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""341adadf-b090-450d-8611-278e9f48febd"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6fa25f2b-b271-41fa-ad85-6fb769fae99e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""b760d582-62a5-45ef-b23c-c5e30d4d9140"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Value"",
                    ""id"": ""959bcdb3-5a5b-444c-a19d-c0cc1d75df94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Climb"",
                    ""type"": ""Button"",
                    ""id"": ""164554d8-dca0-4753-bbf1-f26a7fdd6df1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""329dcd97-acb9-491e-8bcf-c357ad7159e2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b3d40f8b-2e21-4099-b52f-70a7914f2aa1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""86c66fcc-5e62-43da-95eb-d0cf53280495"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9958672e-0da2-4895-82ca-65f2b8260204"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6cde21bb-eb0e-4ed6-9f2b-4f74f35f4253"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c56e9c83-1efe-418c-a845-cb1a55ed9b15"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b205c5e-4941-49a1-8bee-9f1c0c781d3d"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Climb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Rope"",
            ""id"": ""a50dfa8f-4b79-4d33-b09e-e6802171b86b"",
            ""actions"": [
                {
                    ""name"": ""Swing"",
                    ""type"": ""Value"",
                    ""id"": ""5720b610-11bf-42cf-b6ce-20910e21d26d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b8bda462-20dc-4f9b-bcca-2df6c32a2151"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Climb"",
                    ""type"": ""Value"",
                    ""id"": ""c887eac3-1716-4259-81c4-6460d3f90d93"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""5e902308-e3d3-46f9-9171-d85127eae34a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swing"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""293a3ad1-8958-40b3-b269-2ef6bbd75304"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Swing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c7168c10-ca02-4031-8645-9a167b7ed0d3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Swing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Vertical"",
                    ""id"": ""d4f3beb8-09ef-4879-92a3-affb071525dd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Climb"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""29792432-edab-40d9-97d2-e1429c0ac612"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Climb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f51ebc0c-5ae9-4c71-9b0b-9b9e7edf022c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Climb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a3f46b00-f959-45cf-8662-fd214f99cba5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Water"",
            ""id"": ""e271f052-c814-4367-9ea2-184767b40b8d"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""327f55af-3701-4718-82ea-9a2238db9460"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""2aa8bfba-a589-42ce-8299-9ed7fd1cf25c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Strafe"",
                    ""type"": ""Value"",
                    ""id"": ""ca3f1359-3108-4daf-8a84-a63f92a935ab"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""64da0ee2-adbe-46d3-97ca-9c6389eab53c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b3c379a7-ece5-49b2-a04b-e3c04245f6f1"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Vertical"",
                    ""id"": ""a4b80af3-13ae-408a-95ad-acdef7d2d8b7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e3d0a409-0ac6-4a46-be66-cc3956144056"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7680e917-2c5d-4965-a38b-dc57a4991a2f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""0a071405-742c-40fd-ad6d-611a0c092ad8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9f071112-212a-4e74-887a-c72347060d33"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""52767f9e-abe0-4339-9fb3-8af7de5b4fc0"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""fdaf4ab6-d9c5-433d-8dc8-0423dcef83fa"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0e4820ce-2f34-47fe-afcd-92d68579205b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d0d98194-2016-48ff-8168-9461f074e5e7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MouseAndKeyboard"",
            ""bindingGroup"": ""MouseAndKeyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Land
        m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
        m_Land_Movement = m_Land.FindAction("Movement", throwIfNotFound: true);
        m_Land_Jump = m_Land.FindAction("Jump", throwIfNotFound: true);
        m_Land_Dash = m_Land.FindAction("Dash", throwIfNotFound: true);
        m_Land_Sprint = m_Land.FindAction("Sprint", throwIfNotFound: true);
        m_Land_Climb = m_Land.FindAction("Climb", throwIfNotFound: true);
        // Rope
        m_Rope = asset.FindActionMap("Rope", throwIfNotFound: true);
        m_Rope_Swing = m_Rope.FindAction("Swing", throwIfNotFound: true);
        m_Rope_Jump = m_Rope.FindAction("Jump", throwIfNotFound: true);
        m_Rope_Climb = m_Rope.FindAction("Climb", throwIfNotFound: true);
        // Water
        m_Water = asset.FindActionMap("Water", throwIfNotFound: true);
        m_Water_Movement = m_Water.FindAction("Movement", throwIfNotFound: true);
        m_Water_Rotate = m_Water.FindAction("Rotate", throwIfNotFound: true);
        m_Water_Strafe = m_Water.FindAction("Strafe", throwIfNotFound: true);
        m_Water_Boost = m_Water.FindAction("Boost", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Land
    private readonly InputActionMap m_Land;
    private List<ILandActions> m_LandActionsCallbackInterfaces = new List<ILandActions>();
    private readonly InputAction m_Land_Movement;
    private readonly InputAction m_Land_Jump;
    private readonly InputAction m_Land_Dash;
    private readonly InputAction m_Land_Sprint;
    private readonly InputAction m_Land_Climb;
    public struct LandActions
    {
        private @Controls m_Wrapper;
        public LandActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Land_Movement;
        public InputAction @Jump => m_Wrapper.m_Land_Jump;
        public InputAction @Dash => m_Wrapper.m_Land_Dash;
        public InputAction @Sprint => m_Wrapper.m_Land_Sprint;
        public InputAction @Climb => m_Wrapper.m_Land_Climb;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void AddCallbacks(ILandActions instance)
        {
            if (instance == null || m_Wrapper.m_LandActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_LandActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Dash.started += instance.OnDash;
            @Dash.performed += instance.OnDash;
            @Dash.canceled += instance.OnDash;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Climb.started += instance.OnClimb;
            @Climb.performed += instance.OnClimb;
            @Climb.canceled += instance.OnClimb;
        }

        private void UnregisterCallbacks(ILandActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Dash.started -= instance.OnDash;
            @Dash.performed -= instance.OnDash;
            @Dash.canceled -= instance.OnDash;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Climb.started -= instance.OnClimb;
            @Climb.performed -= instance.OnClimb;
            @Climb.canceled -= instance.OnClimb;
        }

        public void RemoveCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ILandActions instance)
        {
            foreach (var item in m_Wrapper.m_LandActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_LandActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public LandActions @Land => new LandActions(this);

    // Rope
    private readonly InputActionMap m_Rope;
    private List<IRopeActions> m_RopeActionsCallbackInterfaces = new List<IRopeActions>();
    private readonly InputAction m_Rope_Swing;
    private readonly InputAction m_Rope_Jump;
    private readonly InputAction m_Rope_Climb;
    public struct RopeActions
    {
        private @Controls m_Wrapper;
        public RopeActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Swing => m_Wrapper.m_Rope_Swing;
        public InputAction @Jump => m_Wrapper.m_Rope_Jump;
        public InputAction @Climb => m_Wrapper.m_Rope_Climb;
        public InputActionMap Get() { return m_Wrapper.m_Rope; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RopeActions set) { return set.Get(); }
        public void AddCallbacks(IRopeActions instance)
        {
            if (instance == null || m_Wrapper.m_RopeActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RopeActionsCallbackInterfaces.Add(instance);
            @Swing.started += instance.OnSwing;
            @Swing.performed += instance.OnSwing;
            @Swing.canceled += instance.OnSwing;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Climb.started += instance.OnClimb;
            @Climb.performed += instance.OnClimb;
            @Climb.canceled += instance.OnClimb;
        }

        private void UnregisterCallbacks(IRopeActions instance)
        {
            @Swing.started -= instance.OnSwing;
            @Swing.performed -= instance.OnSwing;
            @Swing.canceled -= instance.OnSwing;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Climb.started -= instance.OnClimb;
            @Climb.performed -= instance.OnClimb;
            @Climb.canceled -= instance.OnClimb;
        }

        public void RemoveCallbacks(IRopeActions instance)
        {
            if (m_Wrapper.m_RopeActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRopeActions instance)
        {
            foreach (var item in m_Wrapper.m_RopeActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RopeActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RopeActions @Rope => new RopeActions(this);

    // Water
    private readonly InputActionMap m_Water;
    private List<IWaterActions> m_WaterActionsCallbackInterfaces = new List<IWaterActions>();
    private readonly InputAction m_Water_Movement;
    private readonly InputAction m_Water_Rotate;
    private readonly InputAction m_Water_Strafe;
    private readonly InputAction m_Water_Boost;
    public struct WaterActions
    {
        private @Controls m_Wrapper;
        public WaterActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Water_Movement;
        public InputAction @Rotate => m_Wrapper.m_Water_Rotate;
        public InputAction @Strafe => m_Wrapper.m_Water_Strafe;
        public InputAction @Boost => m_Wrapper.m_Water_Boost;
        public InputActionMap Get() { return m_Wrapper.m_Water; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WaterActions set) { return set.Get(); }
        public void AddCallbacks(IWaterActions instance)
        {
            if (instance == null || m_Wrapper.m_WaterActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_WaterActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Rotate.started += instance.OnRotate;
            @Rotate.performed += instance.OnRotate;
            @Rotate.canceled += instance.OnRotate;
            @Strafe.started += instance.OnStrafe;
            @Strafe.performed += instance.OnStrafe;
            @Strafe.canceled += instance.OnStrafe;
            @Boost.started += instance.OnBoost;
            @Boost.performed += instance.OnBoost;
            @Boost.canceled += instance.OnBoost;
        }

        private void UnregisterCallbacks(IWaterActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Rotate.started -= instance.OnRotate;
            @Rotate.performed -= instance.OnRotate;
            @Rotate.canceled -= instance.OnRotate;
            @Strafe.started -= instance.OnStrafe;
            @Strafe.performed -= instance.OnStrafe;
            @Strafe.canceled -= instance.OnStrafe;
            @Boost.started -= instance.OnBoost;
            @Boost.performed -= instance.OnBoost;
            @Boost.canceled -= instance.OnBoost;
        }

        public void RemoveCallbacks(IWaterActions instance)
        {
            if (m_Wrapper.m_WaterActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IWaterActions instance)
        {
            foreach (var item in m_Wrapper.m_WaterActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_WaterActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public WaterActions @Water => new WaterActions(this);
    private int m_MouseAndKeyboardSchemeIndex = -1;
    public InputControlScheme MouseAndKeyboardScheme
    {
        get
        {
            if (m_MouseAndKeyboardSchemeIndex == -1) m_MouseAndKeyboardSchemeIndex = asset.FindControlSchemeIndex("MouseAndKeyboard");
            return asset.controlSchemes[m_MouseAndKeyboardSchemeIndex];
        }
    }
    public interface ILandActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnClimb(InputAction.CallbackContext context);
    }
    public interface IRopeActions
    {
        void OnSwing(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnClimb(InputAction.CallbackContext context);
    }
    public interface IWaterActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnStrafe(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
    }
}