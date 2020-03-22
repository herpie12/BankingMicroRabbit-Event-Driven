using MicroRabbit.Transfer.Domain.EventHandlers;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Domain.Interfaces
{
   public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferlogs();

        void SaveTransferLog(TransferLog transferLog);
    }
}
