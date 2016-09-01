using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "GameService" в коде и файле конфигурации.
    [ServiceBehavior(
        ConcurrencyMode = ConcurrencyMode.Single,
        InstanceContextMode = InstanceContextMode.PerCall)]
    public class GameService : IGameService
    {
        private static Dictionary<int, IGameServiceCallback> _callbackList = new Dictionary<int, IGameServiceCallback>();
        private static int i;

        public void CreateGame()
        {
            _callbackList[0].CallBack($"danuna? Zarabotalo? {i++}");
        }

        public void JoinGame()
        {
            throw new NotImplementedException();
        }

        public void JoinById(int id)
        {
            var callback = OperationContext.Current.GetCallbackChannel<IGameServiceCallback>();
            _callbackList.Add(id, callback);
        }

        public void SendById(int id, string message)
        {
            if (_callbackList.ContainsKey(id))
            {
                _callbackList[id].CallBack(message);
            }
        }
    }
    
}
