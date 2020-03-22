using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Transfer.Domain.EventHandlers;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _ctx;
        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<TransferLog> GetTransferlogs()
        {
            return _ctx.Transferlogs;
        }

        public void SaveTransferLog(TransferLog transferLog)
        {
            if (transferLog != null)
            {
                _ctx.Add(transferLog);
                _ctx.SaveChanges();
            }      
        }
    }
}
