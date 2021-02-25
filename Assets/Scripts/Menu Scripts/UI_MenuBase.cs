using UnityEngine;

namespace LLFramework
{
    public abstract class UI_MenuBase : MonoBehaviour
    {
        /// <summary>
        /// è un riferimento al proprio manager
        /// </summary>
        protected UI_ManagerBase managerBase;

        /// <summary>
        /// stato di attivo o disattivo del menu
        /// </summary>
        bool isActive;

        
        /// <summary>
        /// funzione che attiva o disattiva il gameObject del menu
        /// </summary>
        public virtual void ToggleMenu(bool _value)
        {
            if(isActive == _value)
                return;

            isActive = _value;
            gameObject.SetActive(isActive);           
        }

        /// <summary>
        /// setup del menu
        /// </summary>
        public void Setup(UI_ManagerBase _uiManagerBase)
        {
            managerBase = _uiManagerBase;
            isActive = true;
        }

        /// <summary>
        /// funzione chiamata al setup della classe base
        /// </summary>
        protected virtual void OnSetup()
        {

        }

        /// <summary>
        /// funzione che ritorna il valore true o false del menu attivo
        /// </summary>
        /// <returns></returns>
        public bool IsMenuActive()
        {
            return isActive;
        }
    }
}                              