using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructureGenerator
{
    public partial class DisplayFrameCodeSnipplesTextTemplate
    {
        private IList<string> Model { get; set; }
        private readonly string frameName;

        public DisplayFrameCodeSnipplesTextTemplate(FrameDescriptionModel model)
        {
            this.Model = model.Fields.Skip(4).Select(p => p.Item2).ToList();
            this.Model.RemoveAt(this.Model.Count - 1);
            this.frameName = model.StructureName;
        }

        private string GetDisplayName(string name)
        {
            var result = string.Empty;
            if (char.IsLower(name, 0))
            {
                result = name.Substring(1);
            }
            else
            {
                result = name;
            }
            return result + "：";
        }

        private string GetLabelTitleName(string name)
        {
            return string.Format("label_{0}_{1}_title", this.frameName, name);
        }

        private string GetLabelValueName(string name)
        {
            return string.Format("label_{0}_{1}_value", this.frameName, name);
        }
    }
}
