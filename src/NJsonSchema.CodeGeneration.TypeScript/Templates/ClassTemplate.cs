﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace NJsonSchema.CodeGeneration.TypeScript.Templates
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal partial class ClassTemplate : ClassTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 2 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(Model.HasDescription){
            
            #line default
            #line hidden
            this.Write("/** ");
            
            #line 2 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Description));
            
            #line default
            #line hidden
            this.Write(" */\r\n");
            
            #line 3 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("export class ");
            
            #line 3 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Class));
            
            #line default
            #line hidden
            
            #line 3 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Inheritance));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 4 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
foreach(var property in Model.Properties){
            
            #line default
            #line hidden
            
            #line 5 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
  if(property.HasDescription){
            
            #line default
            #line hidden
            this.Write("    /** ");
            
            #line 6 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Description));
            
            #line default
            #line hidden
            this.Write(" */\r\n");
            
            #line 7 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
  }
            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 8 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(property.IsReadOnly){
            
            #line default
            #line hidden
            this.Write("readonly ");
            
            #line 8 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 8 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.PropertyName));
            
            #line default
            #line hidden
            
            #line 8 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(property.IsOptional){
            
            #line default
            #line hidden
            this.Write("?");
            
            #line 8 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write(": ");
            
            #line 8 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Type));
            
            #line default
            #line hidden
            
            #line 8 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(Model.SupportsStrictNullChecks){
            
            #line default
            #line hidden
            
            #line 8 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(property.IsNullable){
            
            #line default
            #line hidden
            this.Write(" | null");
            
            #line 8 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write(" | undefined");
            
            #line 8 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 8 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(property.HasDefaultValue){
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 8 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.DefaultValue));
            
            #line default
            #line hidden
            
            #line 8 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 9 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 10 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(Model.HasIndexerProperty){
            
            #line default
            #line hidden
            this.Write("\r\n    [key: string]: ");
            
            #line 12 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.IndexerPropertyValueType));
            
            #line default
            #line hidden
            this.Write("; \r\n");
            
            #line 13 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 14 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(Model.HasDiscriminator){
            
            #line default
            #line hidden
            this.Write("\r\n    protected _discriminator: string;\r\n");
            
            #line 17 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 19 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(Model.HasBaseDiscriminator){
            
            #line default
            #line hidden
            this.Write("    constructor() {\r\n");
            
            #line 21 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(Model.HasInheritance){
            
            #line default
            #line hidden
            this.Write("        super();\r\n");
            
            #line 23 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("        this._discriminator = \"");
            
            #line 24 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.DiscriminatorName));
            
            #line default
            #line hidden
            this.Write("\";\r\n    }\r\n");
            
            #line 26 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n    init(data?: any");
            
            #line 28 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(Model.HandleReferences){
            
            #line default
            #line hidden
            this.Write(", mappings?: any");
            
            #line 28 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write(") {\r\n");
            
            #line 29 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(Model.HasInheritance){
            
            #line default
            #line hidden
            this.Write("        super.init(data);\r\n");
            
            #line 31 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("        if (data !== undefined) {\r\n");
            
            #line 33 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(Model.HasIndexerProperty){
            
            #line default
            #line hidden
            this.Write("            for (var property in data) {\r\n                if (data.hasOwnProperty" +
                    "(property))\r\n                    this[property] = data[property];\r\n            }" +
                    "\r\n");
            
            #line 38 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 39 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
foreach (var property in Model.Properties){
            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 40 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConversionUtilities.Tab(property.ConvertToClassCode, 3)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 41 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("        }\r\n    }\r\n\r\n    static fromJS(data: any");
            
            #line 45 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(Model.HandleReferences){
            
            #line default
            #line hidden
            this.Write(", mappings?: any");
            
            #line 45 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("): ");
            
            #line 45 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Class));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 46 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(Model.HandleReferences){
            
            #line default
            #line hidden
            
            #line 47 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
  if(Model.HasBaseDiscriminator){
            
            #line default
            #line hidden
            
            #line 48 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
      foreach (var derivedClass in Model.DerivedClassNames){
            
            #line default
            #line hidden
            this.Write("        if (data[\"");
            
            #line 49 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.BaseDiscriminator));
            
            #line default
            #line hidden
            this.Write("\"] === \"");
            
            #line 49 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(derivedClass));
            
            #line default
            #line hidden
            this.Write("\")\r\n            return ci<");
            
            #line 50 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(derivedClass));
            
            #line default
            #line hidden
            this.Write(">(data, mappings, () => new ");
            
            #line 50 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(derivedClass));
            
            #line default
            #line hidden
            this.Write("());\r\n");
            
            #line 51 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
      }
            
            #line default
            #line hidden
            this.Write("        return ci<");
            
            #line 52 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Class));
            
            #line default
            #line hidden
            this.Write(">(data, mappings, () => new ");
            
            #line 52 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Class));
            
            #line default
            #line hidden
            this.Write("());\r\n");
            
            #line 53 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
  }else{
            
            #line default
            #line hidden
            this.Write("        return ci<");
            
            #line 54 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Class));
            
            #line default
            #line hidden
            this.Write(">(data, mappings, () => new ");
            
            #line 54 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Class));
            
            #line default
            #line hidden
            this.Write("());\r\n");
            
            #line 55 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
  }
            
            #line default
            #line hidden
            
            #line 56 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}else{
            
            #line default
            #line hidden
            
            #line 57 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
  if(Model.HasBaseDiscriminator){
            
            #line default
            #line hidden
            
            #line 58 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
      foreach (var derivedClass in Model.DerivedClassNames){
            
            #line default
            #line hidden
            this.Write("        if (data[\"");
            
            #line 59 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.BaseDiscriminator));
            
            #line default
            #line hidden
            this.Write("\"] === \"");
            
            #line 59 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(derivedClass));
            
            #line default
            #line hidden
            this.Write("\") {\r\n            let result = new ");
            
            #line 60 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(derivedClass));
            
            #line default
            #line hidden
            this.Write("();\r\n            result.init(data);\r\n            return result;\r\n        }\r\n");
            
            #line 64 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
      }
            
            #line default
            #line hidden
            
            #line 65 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
  }
            
            #line default
            #line hidden
            this.Write("        let result = new ");
            
            #line 66 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Class));
            
            #line default
            #line hidden
            this.Write("();\r\n        result.init();\r\n        return result;\r\n");
            
            #line 69 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("    }\r\n\r\n    toJS(data?: any) {\r\n        data = data === undefined ? {} : data;\r\n" +
                    "");
            
            #line 74 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(Model.HasIndexerProperty){
            
            #line default
            #line hidden
            this.Write("        for (var property in this) {\r\n            if (this.hasOwnProperty(propert" +
                    "y))\r\n                data[property] = this[property];\r\n        }\r\n");
            
            #line 79 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 80 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(Model.HasDiscriminator){
            
            #line default
            #line hidden
            this.Write("        data[\"");
            
            #line 81 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.BaseDiscriminator));
            
            #line default
            #line hidden
            this.Write("\"] = this._discriminator; \r\n");
            
            #line 82 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 83 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
foreach (var property in Model.Properties){
            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 84 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConversionUtilities.Tab(property.ConvertToJavaScriptCode, 2)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 85 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 86 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
if(Model.HasInheritance){
            
            #line default
            #line hidden
            this.Write("        super.toJS(data);\r\n");
            
            #line 88 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("        return data; \r\n    }\r\n\r\n    toJSON() {\r\n        return JSON.stringify(thi" +
                    "s.toJS());\r\n    }\r\n\r\n    clone() {\r\n        let clone = new ");
            
            #line 97 "C:\Data\Projects\NJsonSchema\src\NJsonSchema.CodeGeneration.TypeScript\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Class));
            
            #line default
            #line hidden
            this.Write("();\r\n        for (var property in this) {\n            if (this.hasOwnProperty(pro" +
                    "perty))\n                clone[property] = this[property];\n        }\n        retu" +
                    "rn clone;\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal class ClassTemplateBase
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
