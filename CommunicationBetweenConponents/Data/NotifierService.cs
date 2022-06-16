using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationBetweenConponents.Data
{
    public class NotifierService
    {
        public int PinkScale { get; private set; }
        public event Action OnScaleChange;

        public void SetPattern(int newPinkScale)
        {
            PinkScale = newPinkScale;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnScaleChange?.Invoke();
    }
}
