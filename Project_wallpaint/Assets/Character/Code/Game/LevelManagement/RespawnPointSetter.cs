using System.Collections;
using UnityEngine;
//--------------------------------------------------------------------
//When the character enters, the respawn point associated with this trigger will be used as the new startpoint
//--------------------------------------------------------------------
public class RespawnPointSetter : MonoBehaviour {
    [SerializeField] int m_Index;

    void OnTriggerEnter () {
        if (InSceneLevelSwitcher.Get ()) {
            InSceneLevelSwitcher.Get ().SetIndex (m_Index);
        }
    }
}