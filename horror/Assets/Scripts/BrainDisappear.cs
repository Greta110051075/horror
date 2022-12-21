using UnityEngine;
using UnityEditor.Events;

namespace greta
{
    
    public class BrainDisappear : MonoBehaviour
    {
        [SerializeField, Header("消失物件")]
        public GameObject brain;

        private DialogueSystem dialogueSystem;

        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;

        private string nameTarget = "PlayerCapsule";

        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameTarget))
            {
                dialogueSystem.StartDialogue(dataDialogue);
            }
        }

    }
}


