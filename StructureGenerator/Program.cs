using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StructureGenerator
{
    class Program
    {
        const string BaseNamespace = "ReceiveAndParse";
        const string UnderlyingFolderName = "Underlying";
        const string ModelFolderName = "Models";
        const string CodeSnipplesFolderName = "Codes";

        static void Main(string[] args)
        {
            Directory.CreateDirectory(UnderlyingFolderName);
            Directory.CreateDirectory(ModelFolderName);
            Directory.CreateDirectory(CodeSnipplesFolderName);
            foreach(var model in ParseModels("FrameDescriptions.txt"))
            {
                var underlyingTemplate = new UnderlyingStructureTemplate(BaseNamespace, model);

                var underlyingFilePath = Path.Combine(UnderlyingFolderName, model.StructureName + ".cs");
                File.WriteAllText(underlyingFilePath, underlyingTemplate.TransformText());

                var modelTemplate = new ModelClassTemplateTemplate(BaseNamespace, model);

                var modelFilePath = Path.Combine(ModelFolderName, model.StructureName + ".cs");
                File.WriteAllText(modelFilePath, modelTemplate.TransformText());

                var codeTemplate = new DisplayFrameCodeSnipplesTextTemplate(model);

                var codeFilePath = Path.Combine(CodeSnipplesFolderName, model.StructureName + ".txt");
                File.WriteAllText(codeFilePath, codeTemplate.TransformText());
            }
        }

        static string CombineNamespace(string ns1, string ns2)
        {
            return string.Format("{0}.{1}", ns1, ns2);        
        }

        static IEnumerable<FrameDescriptionModel> ParseModels(string filename)
        {
            IEnumerable<string> lines = null;
            try
            {
                lines = File.ReadLines(filename);
                using (var enumerator = lines.GetEnumerator())
                {
                    FrameDescriptionModel model = null;
                    while (enumerator.MoveNext())
                    {
                        var line = enumerator.Current;

                        if (string.IsNullOrWhiteSpace(line))
                        {
                            yield return model;
                        }
                        else if (!line.StartsWith("\t"))
                        {
                            model = new FrameDescriptionModel
                            {
                                StructureName = line,
                                Fields = new List<Tuple<string, string>>()
                            };
                        }
                        else
                        {
                            var typeAndName = line.Substring(1).Split(' ');
                            model.Fields.Add(Tuple.Create(typeAndName[0], typeAndName[1]));
                        }
                    }
                }
            }
            finally
            {
                var disposable = lines as IDisposable;
                if (disposable != null)
                {
                    disposable.Dispose();
                }
            }
        }
    }
}
