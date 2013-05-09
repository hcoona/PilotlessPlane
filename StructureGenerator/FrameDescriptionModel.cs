using System;
using System.Collections.Generic;

namespace StructureGenerator
{
    public class FrameDescriptionModel
    {
        public string StructureName { get; set; }
        public IList<Tuple<string, string>> Fields { get; set; }

        public override string ToString()
        {
            return string.Format(
                "{0}\n{1}",
                StructureName,
                string.Join(" ", Fields));
        }
    }
}
