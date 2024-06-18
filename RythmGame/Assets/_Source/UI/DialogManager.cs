using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

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

        [SerializeField] bool _toGame = false;
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
                    Time.timeScale = 0f;
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
                if (_toGame == true)
                {
                    SceneManager.LoadScene("PlayScreen");
                }
                _manager.Close();
            }
        }
    }

}
