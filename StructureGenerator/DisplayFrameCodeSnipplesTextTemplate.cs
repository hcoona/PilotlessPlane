﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 11.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace StructureGenerator
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class DisplayFrameCodeSnipplesTextTemplate : DisplayFrameCodeSnipplesTextTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n");
            
            #line 7 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 const int RowHeight = 20; 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 9 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 foreach (var name in this.Model) { 
            
            #line default
            #line hidden
            this.Write("\t\t\tSystem.Windows.Forms.Label ");
            
            #line 10 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelTitleName(name)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 11 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 13 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 foreach (var name in this.Model) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 14 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelTitleName(name)));
            
            #line default
            #line hidden
            this.Write(" = new System.Windows.Forms.Label();\r\n");
            
            #line 15 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n            tableLayoutPanel_");
            
            #line 17 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.frameName));
            
            #line default
            #line hidden
            this.Write(".RowCount = ");
            
            #line 17 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Model.Count));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 18 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 foreach (var _ in this.Model) { 
            
            #line default
            #line hidden
            this.Write("            tableLayoutPanel_");
            
            #line 19 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.frameName));
            
            #line default
            #line hidden
            this.Write(".RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Ab" +
                    "solute, ");
            
            #line 19 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(RowHeight));
            
            #line default
            #line hidden
            this.Write("F));\r\n");
            
            #line 20 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 22 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 for (var i = 0; i < this.Model.Count; i++) { 
            
            #line default
            #line hidden
            this.Write("            tableLayoutPanel_");
            
            #line 23 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.frameName));
            
            #line default
            #line hidden
            this.Write(".Controls.Add(");
            
            #line 23 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelTitleName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(", 0, ");
            
            #line 23 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 24 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 26 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 for (var i = 0; i < this.Model.Count; i++) { 
            
            #line default
            #line hidden
            this.Write("            // \r\n            // ");
            
            #line 28 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelTitleName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write("\r\n            // \r\n            ");
            
            #line 30 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelTitleName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".AutoSize = true;\r\n            ");
            
            #line 31 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelTitleName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".Dock = System.Windows.Forms.DockStyle.Fill;\r\n            ");
            
            #line 32 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelTitleName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".Location = new System.Drawing.Point(3, ");
            
            #line 32 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(RowHeight * i));
            
            #line default
            #line hidden
            this.Write(");\r\n            ");
            
            #line 33 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelTitleName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".Margin = new System.Windows.Forms.Padding(0);\r\n            ");
            
            #line 34 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelTitleName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".Name = \"");
            
            #line 34 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelTitleName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write("\";\r\n            ");
            
            #line 35 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelTitleName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".Size = new System.Drawing.Size(121, ");
            
            #line 35 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(RowHeight));
            
            #line default
            #line hidden
            this.Write(");\r\n            ");
            
            #line 36 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelTitleName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".Text = \"");
            
            #line 36 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.GetDisplayName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write("\";\r\n            ");
            
            #line 37 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelTitleName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".TextAlign = System.Drawing.ContentAlignment.TopRight;\r\n");
            
            #line 38 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\r\n\r\n\r\n");
            
            #line 43 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 foreach (var name in this.Model) { 
            
            #line default
            #line hidden
            this.Write("\t\t\tSystem.Windows.Forms.Label ");
            
            #line 44 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelValueName(name)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 45 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 47 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 foreach (var name in this.Model) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 48 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelValueName(name)));
            
            #line default
            #line hidden
            this.Write(" = new System.Windows.Forms.Label();\r\n");
            
            #line 49 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 51 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 for (var i = 0; i < this.Model.Count; i++) { 
            
            #line default
            #line hidden
            this.Write("            tableLayoutPanel_");
            
            #line 52 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.frameName));
            
            #line default
            #line hidden
            this.Write(".Controls.Add(");
            
            #line 52 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelValueName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(", 1, ");
            
            #line 52 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 53 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 55 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 for (var i = 0; i < this.Model.Count; i++) { 
            
            #line default
            #line hidden
            this.Write("            // \r\n            // ");
            
            #line 57 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelValueName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write("\r\n            // \r\n            ");
            
            #line 59 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelValueName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".AutoSize = true;\r\n            ");
            
            #line 60 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelValueName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".Dock = System.Windows.Forms.DockStyle.Fill;\r\n            ");
            
            #line 61 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelValueName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".Location = new System.Drawing.Point(3, ");
            
            #line 61 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(RowHeight * i));
            
            #line default
            #line hidden
            this.Write(");\r\n            ");
            
            #line 62 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelValueName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".Margin = new System.Windows.Forms.Padding(0);\r\n            ");
            
            #line 63 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelValueName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".Name = \"GetLabelValueName(this.Model[i])\";\r\n            ");
            
            #line 64 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelValueName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".Size = new System.Drawing.Size(121, ");
            
            #line 64 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(RowHeight));
            
            #line default
            #line hidden
            this.Write(");\r\n            ");
            
            #line 65 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelValueName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".Text = \"0.0\";\r\n            ");
            
            #line 66 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelValueName(this.Model[i])));
            
            #line default
            #line hidden
            this.Write(".TextAlign = System.Drawing.ContentAlignment.TopLeft;\r\n");
            
            #line 67 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\r\n\r\n\r\n");
            
            #line 72 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 foreach (var name in this.Model) { 
            
            #line default
            #line hidden
            this.Write("\t\t\tthis.");
            
            #line 73 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetLabelValueName(name)));
            
            #line default
            #line hidden
            this.Write(".Text = frame.");
            
            #line 73 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(name));
            
            #line default
            #line hidden
            this.Write(".ToString();\r\n");
            
            #line 74 "D:\Projects\PilotlessPlane\StructureGenerator\DisplayFrameCodeSnipplesTextTemplate.tt"
 } 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public class DisplayFrameCodeSnipplesTextTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
