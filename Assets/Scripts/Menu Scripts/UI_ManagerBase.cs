using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace LLFramework
{
    public abstract class UI_ManagerBase : MonoBehaviour
    {     
        /// <summary>
        /// lista dei menu
        /// </summary>
        protected List<UI_MenuBase> menues;

        /// <summary>
        /// Menu attualmente selezionato
        /// </summary>
        protected UI_MenuBase currentMenu;

        
        /// <summary>
        /// Funzione che ritorna il menu attivo
        /// </summary>
        /// <returns> menu attualmente attivo </returns>
        protected UI_MenuBase GetCurrentMenu() 
        {
            return currentMenu;
        }

        /// <summary>
        /// funzione chiamata al setup della classe base
        /// </summary>
        protected virtual void OnSetup()
        {

        }

        /// <summary>
        /// setup della classe
        /// </summary>
        public void Setup()
        {
            menues = GetComponentsInChildren<UI_MenuBase>().ToList();
            foreach (UI_MenuBase item in menues)
                item.Setup(this);
            
            OnSetup();
        }
    }
}
