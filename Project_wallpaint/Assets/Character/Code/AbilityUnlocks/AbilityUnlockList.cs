using System.Collections;
using UnityEngine;

[System.Serializable]
public class AbilityUnlockList {
    [System.Serializable]
    public class AbilityUnlockItem {
        public string m_AbilityName;
        public bool m_Lock;
    };
    public AbilityUnlockItem[] m_List;
}