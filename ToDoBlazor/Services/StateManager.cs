using System;

namespace ToDoBlazor.Services
{
    public class StateManager
    {
        public event Action OnChange;

        public void CallOnChange()
        {
            OnChange?.Invoke();
        }

    }
}
