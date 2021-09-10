using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_test_git.ChainOfRespo
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);//setta l'anello successivo della catena
        LvlApprovazione Handle(LvlApprovazione request); //gestisce la richiesta
    }
}
