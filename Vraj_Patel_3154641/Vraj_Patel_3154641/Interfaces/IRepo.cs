using Vraj_Patel_3154641.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraj_Patel_3154641.Interfaces
{
    public interface IRepo
    {
        void Create<T>(T entity) where T : BaseEntity;
        T Read<T>(int Id) where T : BaseEntity;
        void Update<T>(T entity) where T : BaseEntity;
        void Delete<T>(int Id) where T : BaseEntity;
        void CommitTransacton();

        List<T> GetAll<T>() where T : BaseEntity;

    }
}