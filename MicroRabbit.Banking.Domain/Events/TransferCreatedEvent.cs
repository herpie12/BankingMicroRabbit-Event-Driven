using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TransferCreatedEvent : Event
    {

        public int _from { get; private set; }

        public int _to { get; private set; }

        public decimal _amount { get; private set; }

        public TransferCreatedEvent(int from, int to, decimal amount)
        {
            _from = from;
            _to = to;
            _amount = amount;
        }
    }
}
