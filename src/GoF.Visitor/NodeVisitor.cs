using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Visitor
{
    public abstract class NodeVisitor : INodeVisitor
    {
        public abstract void VisitCategory(Category category);

        public abstract void VisitProduct(Product product);
    }
}
