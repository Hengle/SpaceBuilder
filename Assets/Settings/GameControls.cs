// GENERATED AUTOMATICALLY FROM 'Assets/Settings/GameControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameControls : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""CityBuilding"",
            ""id"": ""638337d0-653d-424b-87b9-48c3441f5ca1"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4921771a-b0e3-47ac-8883-3c3279893f05"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause Game"",
                    ""type"": ""Button"",
                    ""id"": ""687108d1-fe32-4f4e-9125-0b9ac877872e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b6818eb3-d2ae-4403-85c2-2a62759ce960"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""eb9a85dd-32b1-4c68-ad3a-ff99cc720087"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Selection Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b1700b3a-1b24-48f2-aff7-7ece6f7cd640"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4e79f873-7e99-4e86-a8bb-a4ba4cbeec64"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause Game"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4aa757f-c51c-431a-b5ef-16d1c0c7077c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause Game"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0cded4f1-559f-4f33-86f3-18fcfe4c8312"",
                    ""path"": ""2DVector(normalize=false)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2224b88f-a47a-4e5f-ab32-35c29c5ec146"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""358197e0-0432-4272-9a9a-a6b4fdfb86b5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fe483f63-9b2c-409c-b510-7eb805448fa9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5954d86f-9906-498c-be6c-2ac08a95e4a5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c81eb5ba-68e8-43a2-8cf2-11edf3492fec"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""60cc64ee-eb29-4a51-a0f6-f0c0c9044e18"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1bdce39a-b0f5-4b06-8444-fe8b9eb776b3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""21f0e52e-3307-4809-8d92-5ba1e81c243b"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(min=-1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d022149-b4d0-4909-9154-dc82788542c3"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Selection Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CityBuilding
        m_CityBuilding = asset.FindActionMap("CityBuilding", throwIfNotFound: true);
        m_CityBuilding_Movement = m_CityBuilding.FindAction("Movement", throwIfNotFound: true);
        m_CityBuilding_PauseGame = m_CityBuilding.FindAction("Pause Game", throwIfNotFound: true);
        m_CityBuilding_Rotation = m_CityBuilding.FindAction("Rotation", throwIfNotFound: true);
        m_CityBuilding_Zoom = m_CityBuilding.FindAction("Zoom", throwIfNotFound: true);
        m_CityBuilding_SelectionClick = m_CityBuilding.FindAction("Selection Click", throwIfNotFound: true);
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

    // CityBuilding
    private readonly InputActionMap m_CityBuilding;
    private ICityBuildingActions m_CityBuildingActionsCallbackInterface;
    private readonly InputAction m_CityBuilding_Movement;
    private readonly InputAction m_CityBuilding_PauseGame;
    private readonly InputAction m_CityBuilding_Rotation;
    private readonly InputAction m_CityBuilding_Zoom;
    private readonly InputAction m_CityBuilding_SelectionClick;
    public struct CityBuildingActions
    {
        private @GameControls m_Wrapper;
        public CityBuildingActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_CityBuilding_Movement;
        public InputAction @PauseGame => m_Wrapper.m_CityBuilding_PauseGame;
        public InputAction @Rotation => m_Wrapper.m_CityBuilding_Rotation;
        public InputAction @Zoom => m_Wrapper.m_CityBuilding_Zoom;
        public InputAction @SelectionClick => m_Wrapper.m_CityBuilding_SelectionClick;
        public InputActionMap Get() { return m_Wrapper.m_CityBuilding; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CityBuildingActions set) { return set.Get(); }
        public void SetCallbacks(ICityBuildingActions instance)
        {
            if (m_Wrapper.m_CityBuildingActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CityBuildingActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CityBuildingActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CityBuildingActionsCallbackInterface.OnMovement;
                @PauseGame.started -= m_Wrapper.m_CityBuildingActionsCallbackInterface.OnPauseGame;
                @PauseGame.performed -= m_Wrapper.m_CityBuildingActionsCallbackInterface.OnPauseGame;
                @PauseGame.canceled -= m_Wrapper.m_CityBuildingActionsCallbackInterface.OnPauseGame;
                @Rotation.started -= m_Wrapper.m_CityBuildingActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_CityBuildingActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_CityBuildingActionsCallbackInterface.OnRotation;
                @Zoom.started -= m_Wrapper.m_CityBuildingActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_CityBuildingActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_CityBuildingActionsCallbackInterface.OnZoom;
                @SelectionClick.started -= m_Wrapper.m_CityBuildingActionsCallbackInterface.OnSelectionClick;
                @SelectionClick.performed -= m_Wrapper.m_CityBuildingActionsCallbackInterface.OnSelectionClick;
                @SelectionClick.canceled -= m_Wrapper.m_CityBuildingActionsCallbackInterface.OnSelectionClick;
            }
            m_Wrapper.m_CityBuildingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @PauseGame.started += instance.OnPauseGame;
                @PauseGame.performed += instance.OnPauseGame;
                @PauseGame.canceled += instance.OnPauseGame;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @SelectionClick.started += instance.OnSelectionClick;
                @SelectionClick.performed += instance.OnSelectionClick;
                @SelectionClick.canceled += instance.OnSelectionClick;
            }
        }
    }
    public CityBuildingActions @CityBuilding => new CityBuildingActions(this);
    public interface ICityBuildingActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnPauseGame(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnSelectionClick(InputAction.CallbackContext context);
    }
}
