using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Common.Exceptions
{
    class InvalidAttackException : ApplicationException
    {
        public InvalidAttackException()
        {
        }

        public InvalidAttackException(string message) : base(message)
        {
        }

        public override string Message
        {
            get
            {
                return Constants.InvalidAttackAction;
            }
        }
    }
}
