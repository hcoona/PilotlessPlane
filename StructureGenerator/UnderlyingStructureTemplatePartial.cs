namespace StructureGenerator
{
    public partial class UnderlyingStructureTemplate
    {
        private string NamespaceBase { get; set; }
        private FrameDescriptionModel Model { get; set; }

        public UnderlyingStructureTemplate(string namespaceBase, FrameDescriptionModel model)
        {
            this.NamespaceBase = namespaceBase;
            this.Model = model;
        }
    }
}
