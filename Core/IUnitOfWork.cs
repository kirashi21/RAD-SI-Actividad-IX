using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121250036_ActividadRADIX.Core
{
    public interface IUnitOfWork
    {
        IRepository<T> Repository<T>() where T : class;

        // int SaveChanges
        int Guardar();

        // void BeginTransaction
        void ComenzarTransaccion();

        // void RollBackTransaction
        void ReversarTransaccion();

        // void CommitTransaction
        void ConfirmarTransaccion();
    }
}
