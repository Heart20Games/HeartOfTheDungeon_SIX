//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Development/Prefabs/Characters/Player/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GroundMovement"",
            ""id"": ""68936ce1-7dac-4e3a-afbc-8dc23e83038f"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5afb2a4c-38f9-42a6-95bb-f9788364c85c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DieTest"",
                    ""type"": ""Button"",
                    ""id"": ""434f2936-6ea5-4ebc-aed2-76351019f43a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""f20b9006-d9ce-40ef-bf16-fde5f04afb33"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Primary Cast"",
                    ""type"": ""Button"",
                    ""id"": ""ab2ff5e6-76e1-4188-8b31-e550d4e66d1d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Secondary Cast"",
                    ""type"": ""Button"",
                    ""id"": ""aa7655b0-1dc7-4e21-9541-def6bfd63dd6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Switch Weapon"",
                    ""type"": ""Button"",
                    ""id"": ""9c8d0cd9-3328-4fd6-b860-3330f80a7959"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Switch Ability"",
                    ""type"": ""Button"",
                    ""id"": ""0ca15d03-d446-4370-ae98-256ab25941ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Skill Wheel"",
                    ""type"": ""Button"",
                    ""id"": ""216f075d-ea50-4bc4-8bc2-de338f8b2575"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Select Companion"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9b4d422a-4563-4e56-9c2a-2675c39d78b6"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""e5e43ab4-6a8d-4021-8850-a2bb633d0218"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ab13f2c1-90c7-4447-b248-5769dc6089a0"",
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
                    ""id"": ""996b43f3-b7c5-439a-8215-790ea288a4c7"",
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
                    ""id"": ""1cfa3d63-d9d3-4566-8de1-4e2a8a062ebb"",
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
                    ""id"": ""75fbe57e-722d-4021-b1ec-78fde27dcfd0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left JoyStick"",
                    ""id"": ""f4e1178b-dfdd-450a-b1e7-79b6bb75276a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""da726ce9-e5ff-453f-a3b8-4ea33920d94e"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ad88f92f-b134-4da1-9fee-717ea8d08679"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2f896057-ea70-432e-b91f-7230ec40ecfb"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""35b293fe-5866-4da2-b371-82224b4d66b4"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4575b443-be01-4a07-8c35-ebe69a5f87ee"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DieTest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b66dff0-341f-4c1c-85a0-e95816000acd"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b91392e3-38e7-490f-be7e-33d06be862e1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08bcc911-170f-4dae-8c3b-53e4d27ac362"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Cast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ede39a6-7910-46b6-9f40-62b46eca27e3"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Cast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b871c23-33c5-44f3-ba40-aa3b63a71194"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Cast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51627623-c437-452c-a3ee-db1b730264c1"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Cast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc1ecd1e-4a82-4102-978a-53d8b1c15505"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Weapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22aff08f-8c35-49a2-8e71-1dfd6df94817"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Weapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54c38d64-7f14-408a-ac73-5d06cd3ee310"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Ability"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0918806a-9d28-4cc5-bf9b-2add6a8c88b8"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Ability"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fee31364-f1c1-43d4-a416-a360fd573bc1"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill Wheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""DPad"",
                    ""id"": ""0d0a2259-f51f-4173-b169-28325a769e8b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select Companion"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0b4d62c8-a190-40fb-92e9-70daeee5595b"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select Companion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9b6e8fe1-059a-4e3a-8eec-020175334fdf"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select Companion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""24b4b7d7-de3c-48d7-ba57-5ce30b37c6cf"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select Companion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""399e382f-2ab7-4b13-8ca7-a56d89ed1ee6"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select Companion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Dialogue"",
            ""id"": ""de396bac-c3a7-43f4-93f2-4d361a8bf6ef"",
            ""actions"": [
                {
                    ""name"": ""Continue"",
                    ""type"": ""Button"",
                    ""id"": ""053b44bb-f407-4d4d-a0a6-97ef694df359"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Change Selection"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c5a08cf9-d320-46c6-850c-fa21e327155a"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""8a9196ac-13e1-4851-a4d9-3ba9334e90a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""82945459-0420-44b5-901d-f3bad80dd277"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Continue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4079a6ad-52f0-4c3e-a336-042decfa5886"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Continue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left Stick"",
                    ""id"": ""01f86c26-0eeb-4a22-b898-87615aa199fd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Selection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5d9ccf04-5d12-4c7b-a24f-31755d279116"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a7ffc1af-92a0-4f7a-baaf-349b75752b29"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2724f3b1-4351-4d28-b9ea-ed0fdd88dc32"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""28713d0f-f21d-4af1-948b-d19f8c133d35"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""399a85d3-b3a2-47b3-96ff-8d82724a0116"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Selection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""71ae3f31-8825-4cd2-9e23-74d614863ba3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""77fce446-56a9-4040-8123-f2359179f728"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7f36d9b5-eea4-4ff7-952c-0a9f8a8c131f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8c641a79-01b2-4f0f-b552-6ebcf444aece"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f3b3f033-1e90-472f-b9c3-06b985a58f17"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""444c6a2f-c56f-42bf-85d6-6ede5a879ecc"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GroundMovement
        m_GroundMovement = asset.FindActionMap("GroundMovement", throwIfNotFound: true);
        m_GroundMovement_Movement = m_GroundMovement.FindAction("Movement", throwIfNotFound: true);
        m_GroundMovement_DieTest = m_GroundMovement.FindAction("DieTest", throwIfNotFound: true);
        m_GroundMovement_Interact = m_GroundMovement.FindAction("Interact", throwIfNotFound: true);
        m_GroundMovement_PrimaryCast = m_GroundMovement.FindAction("Primary Cast", throwIfNotFound: true);
        m_GroundMovement_SecondaryCast = m_GroundMovement.FindAction("Secondary Cast", throwIfNotFound: true);
        m_GroundMovement_SwitchWeapon = m_GroundMovement.FindAction("Switch Weapon", throwIfNotFound: true);
        m_GroundMovement_SwitchAbility = m_GroundMovement.FindAction("Switch Ability", throwIfNotFound: true);
        m_GroundMovement_SkillWheel = m_GroundMovement.FindAction("Skill Wheel", throwIfNotFound: true);
        m_GroundMovement_SelectCompanion = m_GroundMovement.FindAction("Select Companion", throwIfNotFound: true);
        // Dialogue
        m_Dialogue = asset.FindActionMap("Dialogue", throwIfNotFound: true);
        m_Dialogue_Continue = m_Dialogue.FindAction("Continue", throwIfNotFound: true);
        m_Dialogue_ChangeSelection = m_Dialogue.FindAction("Change Selection", throwIfNotFound: true);
        m_Dialogue_Back = m_Dialogue.FindAction("Back", throwIfNotFound: true);
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

    // GroundMovement
    private readonly InputActionMap m_GroundMovement;
    private IGroundMovementActions m_GroundMovementActionsCallbackInterface;
    private readonly InputAction m_GroundMovement_Movement;
    private readonly InputAction m_GroundMovement_DieTest;
    private readonly InputAction m_GroundMovement_Interact;
    private readonly InputAction m_GroundMovement_PrimaryCast;
    private readonly InputAction m_GroundMovement_SecondaryCast;
    private readonly InputAction m_GroundMovement_SwitchWeapon;
    private readonly InputAction m_GroundMovement_SwitchAbility;
    private readonly InputAction m_GroundMovement_SkillWheel;
    private readonly InputAction m_GroundMovement_SelectCompanion;
    public struct GroundMovementActions
    {
        private @PlayerControls m_Wrapper;
        public GroundMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_GroundMovement_Movement;
        public InputAction @DieTest => m_Wrapper.m_GroundMovement_DieTest;
        public InputAction @Interact => m_Wrapper.m_GroundMovement_Interact;
        public InputAction @PrimaryCast => m_Wrapper.m_GroundMovement_PrimaryCast;
        public InputAction @SecondaryCast => m_Wrapper.m_GroundMovement_SecondaryCast;
        public InputAction @SwitchWeapon => m_Wrapper.m_GroundMovement_SwitchWeapon;
        public InputAction @SwitchAbility => m_Wrapper.m_GroundMovement_SwitchAbility;
        public InputAction @SkillWheel => m_Wrapper.m_GroundMovement_SkillWheel;
        public InputAction @SelectCompanion => m_Wrapper.m_GroundMovement_SelectCompanion;
        public InputActionMap Get() { return m_Wrapper.m_GroundMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundMovementActions set) { return set.Get(); }
        public void SetCallbacks(IGroundMovementActions instance)
        {
            if (m_Wrapper.m_GroundMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMovement;
                @DieTest.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnDieTest;
                @DieTest.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnDieTest;
                @DieTest.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnDieTest;
                @Interact.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnInteract;
                @PrimaryCast.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnPrimaryCast;
                @PrimaryCast.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnPrimaryCast;
                @PrimaryCast.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnPrimaryCast;
                @SecondaryCast.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSecondaryCast;
                @SecondaryCast.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSecondaryCast;
                @SecondaryCast.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSecondaryCast;
                @SwitchWeapon.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSwitchWeapon;
                @SwitchWeapon.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSwitchWeapon;
                @SwitchWeapon.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSwitchWeapon;
                @SwitchAbility.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSwitchAbility;
                @SwitchAbility.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSwitchAbility;
                @SwitchAbility.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSwitchAbility;
                @SkillWheel.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSkillWheel;
                @SkillWheel.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSkillWheel;
                @SkillWheel.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSkillWheel;
                @SelectCompanion.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSelectCompanion;
                @SelectCompanion.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSelectCompanion;
                @SelectCompanion.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSelectCompanion;
            }
            m_Wrapper.m_GroundMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @DieTest.started += instance.OnDieTest;
                @DieTest.performed += instance.OnDieTest;
                @DieTest.canceled += instance.OnDieTest;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @PrimaryCast.started += instance.OnPrimaryCast;
                @PrimaryCast.performed += instance.OnPrimaryCast;
                @PrimaryCast.canceled += instance.OnPrimaryCast;
                @SecondaryCast.started += instance.OnSecondaryCast;
                @SecondaryCast.performed += instance.OnSecondaryCast;
                @SecondaryCast.canceled += instance.OnSecondaryCast;
                @SwitchWeapon.started += instance.OnSwitchWeapon;
                @SwitchWeapon.performed += instance.OnSwitchWeapon;
                @SwitchWeapon.canceled += instance.OnSwitchWeapon;
                @SwitchAbility.started += instance.OnSwitchAbility;
                @SwitchAbility.performed += instance.OnSwitchAbility;
                @SwitchAbility.canceled += instance.OnSwitchAbility;
                @SkillWheel.started += instance.OnSkillWheel;
                @SkillWheel.performed += instance.OnSkillWheel;
                @SkillWheel.canceled += instance.OnSkillWheel;
                @SelectCompanion.started += instance.OnSelectCompanion;
                @SelectCompanion.performed += instance.OnSelectCompanion;
                @SelectCompanion.canceled += instance.OnSelectCompanion;
            }
        }
    }
    public GroundMovementActions @GroundMovement => new GroundMovementActions(this);

    // Dialogue
    private readonly InputActionMap m_Dialogue;
    private IDialogueActions m_DialogueActionsCallbackInterface;
    private readonly InputAction m_Dialogue_Continue;
    private readonly InputAction m_Dialogue_ChangeSelection;
    private readonly InputAction m_Dialogue_Back;
    public struct DialogueActions
    {
        private @PlayerControls m_Wrapper;
        public DialogueActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Continue => m_Wrapper.m_Dialogue_Continue;
        public InputAction @ChangeSelection => m_Wrapper.m_Dialogue_ChangeSelection;
        public InputAction @Back => m_Wrapper.m_Dialogue_Back;
        public InputActionMap Get() { return m_Wrapper.m_Dialogue; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DialogueActions set) { return set.Get(); }
        public void SetCallbacks(IDialogueActions instance)
        {
            if (m_Wrapper.m_DialogueActionsCallbackInterface != null)
            {
                @Continue.started -= m_Wrapper.m_DialogueActionsCallbackInterface.OnContinue;
                @Continue.performed -= m_Wrapper.m_DialogueActionsCallbackInterface.OnContinue;
                @Continue.canceled -= m_Wrapper.m_DialogueActionsCallbackInterface.OnContinue;
                @ChangeSelection.started -= m_Wrapper.m_DialogueActionsCallbackInterface.OnChangeSelection;
                @ChangeSelection.performed -= m_Wrapper.m_DialogueActionsCallbackInterface.OnChangeSelection;
                @ChangeSelection.canceled -= m_Wrapper.m_DialogueActionsCallbackInterface.OnChangeSelection;
                @Back.started -= m_Wrapper.m_DialogueActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_DialogueActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_DialogueActionsCallbackInterface.OnBack;
            }
            m_Wrapper.m_DialogueActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Continue.started += instance.OnContinue;
                @Continue.performed += instance.OnContinue;
                @Continue.canceled += instance.OnContinue;
                @ChangeSelection.started += instance.OnChangeSelection;
                @ChangeSelection.performed += instance.OnChangeSelection;
                @ChangeSelection.canceled += instance.OnChangeSelection;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
            }
        }
    }
    public DialogueActions @Dialogue => new DialogueActions(this);
    public interface IGroundMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnDieTest(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnPrimaryCast(InputAction.CallbackContext context);
        void OnSecondaryCast(InputAction.CallbackContext context);
        void OnSwitchWeapon(InputAction.CallbackContext context);
        void OnSwitchAbility(InputAction.CallbackContext context);
        void OnSkillWheel(InputAction.CallbackContext context);
        void OnSelectCompanion(InputAction.CallbackContext context);
    }
    public interface IDialogueActions
    {
        void OnContinue(InputAction.CallbackContext context);
        void OnChangeSelection(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
    }
}
