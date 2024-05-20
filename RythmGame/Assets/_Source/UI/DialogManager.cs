using UnityEngine;
using NPCSystem;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;

namespace UI
{
    public class DialogManager : MonoBehaviour
    {
        [Serializable]
        public class  Dialog
        {
            public int charID;
            public string text;
        }
        [SerializeField] List<Dialog> _dialogList = new List<Dialog>();
        int _dialogNum = 0;
        [SerializeField] GameObject _dialogBox;
        [SerializeField] GameObject _button;
        DialogBoxManager _manager;
        bool _isShowing = false;

        void Awake()
        {
            _manager = _dialogBox.GetComponent<DialogBoxManager>();
        }

        private void OnCollisionEnter2D (Collision2D collision)
        {
            _button.SetActive(true);
            _isShowing = true;
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            _button.SetActive(false);
            _isShowing = false;
        }


        void Update()
        {
            if (_isShowing == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    _button.SetActive(false);
                    Dialogs();
                    _dialogBox.SetActive(true);
                }
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    _dialogNum++;
                    Dialogs();
                }
            }
        }

        void Dialogs()
        {
            if (_dialogNum < _dialogList.Count)
            {
                
                _manager.Change(_dialogList[_dialogNum].charID, _dialogList[_dialogNum].text);
            }
            else
            {
                _isShowing = false ;
                _dialogNum = 0;
                _manager.Close();
            }
        }
    }

}