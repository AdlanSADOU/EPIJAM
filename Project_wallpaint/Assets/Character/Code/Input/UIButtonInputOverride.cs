using System.Collections;
using UnityEngine;

public class UIButtonInputOverride : MonoBehaviour {
    [SerializeField] PlayerInput m_PlayerInput;
    [SerializeField] string m_InputOverrideName;

    public void GuiButtonDown () {
        m_PlayerInput.GetButton (m_InputOverrideName).SetOverride (true, true);
    }
    public void GuiButtonUp () {
        m_PlayerInput.GetButton (m_InputOverrideName).SetOverride (true, false);
    }
}