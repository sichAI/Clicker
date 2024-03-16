using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay
{
    public abstract class Clickable : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            OnClicked();
        }

        protected virtual void OnClicked()
        {
            throw new NotImplementedException();
        }
    }
}