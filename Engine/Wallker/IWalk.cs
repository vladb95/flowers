using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Wallker
{
    interface IWalk
    {
        void CommentPost(string uid);
        void Visit(string uid);
        void SendMessage(string uid);

        void Controller();
    }
}
