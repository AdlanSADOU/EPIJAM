using System.Collections;
using UnityEngine;

public class LevelStartAbilityLock : MonoBehaviour {
    [SerializeField] AbilityUnlockList m_List;
    [SerializeField] CharacterControllerBase m_Character;

    void Start () {
        m_Character.GetAbilityModuleManager ().ApplyAbilityUnlockList (m_List);
    }
}