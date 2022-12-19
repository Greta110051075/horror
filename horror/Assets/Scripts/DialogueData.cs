using UnityEngine;

namespace greta
{
    [CreateAssetMenu(menuName ="horror/Dialogue Data", fileName ="New Dialogue Data")]
    public class DialogueData : ScriptableObject
    {
        [Header("對話者名稱")]
        public string dialogueName;
        [Header("對話內容"), TextArea(2, 10)]
        public string[] dialogueContents;
    }
}


