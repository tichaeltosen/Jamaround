// GENERATED AUTOMATICALLY FROM 'Assets/Workspaces/Sasha/Actions/PrototypeInputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PrototypeInputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PrototypeInputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PrototypeInputSystem"",
    ""maps"": [
        {
            ""name"": ""PlayerGameplay"",
            ""id"": ""5499bb53-4425-4636-90b4-914c8fa02ce5"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""200960be-ce27-4241-b503-550097c8db32"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Talk"",
                    ""type"": ""Button"",
                    ""id"": ""6c5e4f52-dafc-4fd3-9240-16327886e1bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hit"",
                    ""type"": ""Button"",
                    ""id"": ""8066106b-1535-40f7-b201-573d9f5cfd44"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""c8ba0efe-6d4d-424e-8deb-2d6f98b4097c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2bd46fe9-1884-4e6b-a342-d8fa4e5f411e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""dPad"",
                    ""id"": ""e97dfcd9-bda8-434e-8584-ae4ab19cfbc8"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dc404632-6d19-4f29-879a-ad6b361649af"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4e069fe8-3374-4e38-9fee-527dce77f532"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""91f754dd-5298-4d92-a9d5-54fb75e721f7"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bc4f7c74-947f-472c-89d8-6dbfca371eec"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""wasdKeys"",
                    ""id"": ""0cbdae19-40c8-48b0-a41c-5330cd8ea20b"",
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
                    ""id"": ""55ad15b6-3933-4edb-ba09-8cf98494fc14"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cf74de81-633c-4ac4-9f0a-cb3cf587eca6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""92bad1b9-1115-4367-a93d-8fd15b7bfc42"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""029d8be5-997f-4c7a-94cd-baff3a92d3a2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""arrowKeys"",
                    ""id"": ""1b687823-3d01-4598-b1f3-cc8b353b3199"",
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
                    ""id"": ""0a53a6a5-77fe-4de9-afd0-408967416052"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7398165d-d6eb-46f9-bddb-5c4a09f8e399"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""eff0c2a7-942f-48a2-a036-cbb1fd80289d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a67d0c51-dec8-40cd-867f-d79dcdc5914c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ee3e7c52-ebe6-461a-9f7a-017616f6f1a4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Talk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1999ba13-4f9f-48fd-b1d5-7f458ffc2c81"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Talk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03cd5fde-3bee-43bd-b33f-a0ba27fd6f2c"",
                    ""path"": ""<Keyboard>/numpadEnter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Talk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc472a73-c685-4c4e-97ff-c8689472f435"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""417b913d-2bdc-4be4-a22b-e263d3c3795a"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""728c6589-984a-4159-bd02-6ccc4dbf7934"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61ce4bbd-76cf-4d8b-8de5-c7daccfa629e"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b1be716-3c4a-4dc4-8f7c-e5eab70f3c53"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
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
        }
    ]
}");
        // PlayerGameplay
        m_PlayerGameplay = asset.FindActionMap("PlayerGameplay", throwIfNotFound: true);
        m_PlayerGameplay_Move = m_PlayerGameplay.FindAction("Move", throwIfNotFound: true);
        m_PlayerGameplay_Talk = m_PlayerGameplay.FindAction("Talk", throwIfNotFound: true);
        m_PlayerGameplay_Hit = m_PlayerGameplay.FindAction("Hit", throwIfNotFound: true);
        m_PlayerGameplay_Look = m_PlayerGameplay.FindAction("Look", throwIfNotFound: true);
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

    // PlayerGameplay
    private readonly InputActionMap m_PlayerGameplay;
    private IPlayerGameplayActions m_PlayerGameplayActionsCallbackInterface;
    private readonly InputAction m_PlayerGameplay_Move;
    private readonly InputAction m_PlayerGameplay_Talk;
    private readonly InputAction m_PlayerGameplay_Hit;
    private readonly InputAction m_PlayerGameplay_Look;
    public struct PlayerGameplayActions
    {
        private @PrototypeInputSystem m_Wrapper;
        public PlayerGameplayActions(@PrototypeInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerGameplay_Move;
        public InputAction @Talk => m_Wrapper.m_PlayerGameplay_Talk;
        public InputAction @Hit => m_Wrapper.m_PlayerGameplay_Hit;
        public InputAction @Look => m_Wrapper.m_PlayerGameplay_Look;
        public InputActionMap Get() { return m_Wrapper.m_PlayerGameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerGameplayActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerGameplayActions instance)
        {
            if (m_Wrapper.m_PlayerGameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnMove;
                @Talk.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnTalk;
                @Talk.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnTalk;
                @Talk.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnTalk;
                @Hit.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnHit;
                @Hit.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnHit;
                @Hit.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnHit;
                @Look.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_PlayerGameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Talk.started += instance.OnTalk;
                @Talk.performed += instance.OnTalk;
                @Talk.canceled += instance.OnTalk;
                @Hit.started += instance.OnHit;
                @Hit.performed += instance.OnHit;
                @Hit.canceled += instance.OnHit;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public PlayerGameplayActions @PlayerGameplay => new PlayerGameplayActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
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
    public interface IPlayerGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnTalk(InputAction.CallbackContext context);
        void OnHit(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
}
