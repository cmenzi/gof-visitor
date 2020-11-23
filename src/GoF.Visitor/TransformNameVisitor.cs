using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Visitor
{
    public class TransformNameVisitor : NodeVisitor
    {
        public override void VisitCategory(Category category)
        {
            category.Name = category.Name.ToUpper();
        }

        public override void VisitProduct(Product product)
        {
            product.Name = product.Name.ToLower();
        }
    }
}
