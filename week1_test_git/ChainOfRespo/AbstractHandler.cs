using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_test_git.ChainOfRespo
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler; //tiene traccia dell'anello successivo
        public virtual LvlApprovazione Handle(LvlApprovazione request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else return LvlApprovazione.NonApprovata;
        }
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return _nextHandler;
        }
    }
}
