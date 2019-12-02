using System;
using System.ServiceModel;

namespace mailkontrol
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IControl
    {
        [OperationContract]
        string kontrol(string a);
    }
}