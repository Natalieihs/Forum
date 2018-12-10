using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Services.Interfaces
{
    public interface IonlineusersService: IBaseServer<bma_onlineusers>
    {
        Task<List<bma_onlineusers>> Get_Onlineusers();
    }
}
