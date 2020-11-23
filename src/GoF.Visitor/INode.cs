using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Visitor
{
    public interface INode
    {
        void Accept(INodeVisitor visitor);
    }
}
