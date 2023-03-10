using UnityEngine;
using UnityEngine.Events;
using UnityEngine.PlayerLoop;

namespace greta
{

    public class InteractableSysttem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;

        [SerializeField, Header("對話結束後事件")]
        private UnityEvent onDialogueFinish;  

        [SerializeField, Header("啟動道具")]
        private GameObject propActive;
        [SerializeField, Header("啟動後的對話資料")]
        private DialogueData dataDialogueActive;

        [SerializeField, Header("起動後對話結束後事件")]
        private UnityEvent onDialogueFinishActive;



        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;

        private float appearTime = 0.5f;

        private void Awake()
        {
            dialogueSystem = GameObject.Find("畫布對話系統").GetComponent<DialogueSystem>();
        }

        private void Start()
        {
            
        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameTarget))
            {
                print(other.name);

 
                if (propActive == null || propActive.activeInHierarchy)
                {
                    dialogueSystem.StartDialogue(dataDialogue, onDialogueFinish);
                }
                else
                {
                    dialogueSystem.StartDialogue(dataDialogueActive, onDialogueFinishActive);
                }
            }


        }

            



        public void HiddenObject()
        {
            gameObject.SetActive(false);


        }

        public void OnBecameVisible()
        {
            gameObject.SetActive(true);
           
        }

    }

}

