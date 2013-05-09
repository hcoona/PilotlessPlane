namespace StructureGenerator
{
    public partial class ModelClassTemplateTemplate
    {
        private string NamespaceBase { get; set; }
        private FrameDescriptionModel Model { get; set; }

        public ModelClassTemplateTemplate(string namespaceBase, FrameDescriptionModel model)
        {
            this.NamespaceBase = namespaceBase;
            this.Model = model;
        }
    }
}
