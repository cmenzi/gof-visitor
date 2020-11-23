namespace GoF.Visitor
{
    public interface INodeVisitor
    {
        void VisitCategory(Category category);

        void VisitProduct(Product product);
    }
}