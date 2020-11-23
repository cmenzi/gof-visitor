using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Visitor
{
    public class Product : INode
    {
        public string Name { get; internal set; }

        public decimal Price { get; internal set; }

        public void Accept(INodeVisitor visitor)
        {
            visitor.VisitProduct(this);
        }
    }
}
