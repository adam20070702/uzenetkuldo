using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using uzenetkuldo.Models;

namespace uzenetkuldo
{
    
    [ServiceContract]
    public interface IUzenetService
    {

        [OperationContract]
        List<Uzenet> GetAllUzenet();

        [OperationContract]
        string CreateUzenet(Uzenet uzenet);

        [OperationContract]
        string UpdateUzenet(Uzenet uzenet);

        [OperationContract]
        string DeleteUzenet(int id);

    }


    
}
