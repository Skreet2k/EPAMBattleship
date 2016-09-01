using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IGameService" в коде и файле конфигурации.
    [ServiceContract(CallbackContract = typeof(IGameServiceCallback))]
    public interface IGameService
    {
        [OperationContract(IsOneWay = true)]
        void CreateGame();
        [OperationContract(IsOneWay = true)]
        void JoinGame();
        [OperationContract(IsOneWay = true)]
        void JoinById(int id);

        [OperationContract(IsOneWay = true)]
        void SendById(int id, string message);
    }

    [ServiceContract]
    public interface IGameServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void CallBack(string message);
    }
}
