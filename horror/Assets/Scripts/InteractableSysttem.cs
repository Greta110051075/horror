using UnityEngine;

namespace greta
{
    public class InteractableSysttem : MonoBehaviour
    {
        [SerializeField, Header("��ܸ��")]
        private DialogueData dataDialogue;

        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;

        private void Awake()
        {
            dialogueSystem = GameObject.Find("�e����ܨt��").GetComponent<DialogueSystem>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameTarget)) 
            {
                dialogueSystem.StartDialogue(dataDialogue);
            }    
        }
    }
}

