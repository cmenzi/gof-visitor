using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Visitor
{
    public class Category : INode
    {
        private readonly List<INode> _items;

        public Category()
        {
            _items = new List<INode>();
        }

        public IReadOnlyList<INode> Items => _items.AsReadOnly();

        public string Name { get; internal set; }
        
        public void Add(INode node)
        {
            _items.Add(node);
        }

        public bool Remove(INode node)
        {
            return _items.Remove(node);
        }

        public void Accept(INodeVisitor visitor)
        {
            visitor.VisitCategory(this);

            foreach (var item in _items)
            {
                item.Accept(visitor);
            }
        }
    }
}
