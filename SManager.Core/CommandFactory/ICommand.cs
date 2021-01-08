using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SManager.Core.CommandFactory
{
    public interface ICommand
    {
        string GetName();

        void SetName(string value);

        bool IsPrimed { get; }

        void Execute();
    }
}