﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class StructureGenerator : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Xml.Serialization;" +
                    "\r\nusing System.Text;\r\nusing System.IO;\r\n\r\nusing Amazon.Runtime;\r\nusing Amazon.Ru" +
                    "ntime.Internal;\r\n\r\nnamespace ");
            
            #line 18 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model\r\n{\r\n");
            
            #line 20 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

	if(this.StructureType == StructureType.Request)
		this.FormatOperationRequestDocumentation(this.Operation);
	else if (this.Operation != null && GeneratorHelpers.HasSuppressedResult(this.Operation))
		this.FormatVoidResultDocumentation(this.Operation.Name);
	else
	    this.FormatClassDocumentation(this.Structure);  

            
            #line default
            #line hidden
            this.Write("\tpublic partial class ");
            
            #line 28 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.ClassName));
            
            #line default
            #line hidden
            
            #line 28 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.BaseClassString));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n");
            
            #line 30 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

        if(this.Structure != null)
        {
            if(this.IsWrapped)
            {

            
            #line default
            #line hidden
            this.Write("        private ");
            
            #line 36 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(" _response;\r\n");
            
            #line 37 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

            }
            else
            {
		        foreach(var member in this.Structure.Members)
                {
					if (member.IsExcluded)
						continue;

            
            #line default
            #line hidden
            this.Write("        private ");
            
            #line 46 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineType()));
            
            #line default
            #line hidden
            
            #line 46 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.IsNullable ? "?" : ""));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 46 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            
            #line 46 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.ShouldInstantiate ? string.Format(" = new {0}();", member.DetermineType()) : ";"));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 47 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

                }
            }
        }

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 53 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

        if(this.Structure != null)
        {
            if(this.IsWrapped)
            {

            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 59 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 59 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            get { return this._response; }\r\n            set { this._" +
                    "response = value; }\r\n        }\r\n");
            
            #line 64 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

            }
            else
            {
        AddSimpleRequestConstructors(this.ClassName, this.Structure, this.Config.Namespace);
		        foreach(var member in this.Structure.Members)
                {
					if (member.IsExcluded)
						continue;

            
            #line default
            #line hidden
            
            #line 74 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
 this.FormatPropertyDocumentation(member); 
            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 75 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.AccessModifier));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 75 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineType()));
            
            #line default
            #line hidden
            
            #line 75 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.UseNullable ? "?" : ""));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 75 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n");
            
            #line 77 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

                    if(member.IsNullable && !member.UseNullable)
                    {

            
            #line default
            #line hidden
            this.Write("            get { return this.");
            
            #line 81 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(".GetValueOrDefault(); }\r\n");
            
            #line 82 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

                    }
                    else
                    {

            
            #line default
            #line hidden
            this.Write("            get { return this.");
            
            #line 87 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write("; }\r\n");
            
            #line 88 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

                    }

            
            #line default
            #line hidden
            this.Write("            set { this.");
            
            #line 91 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(" = value; }\r\n        }\r\n\r\n        // Check to see if ");
            
            #line 94 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" property is set\r\n        internal bool IsSet");
            
            #line 95 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("()\r\n        {\r\n");
            
            #line 97 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

                    if(member.IsNullable)
                    {

            
            #line default
            #line hidden
            this.Write("            return this.");
            
            #line 101 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(".HasValue; \r\n");
            
            #line 102 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

                    }
                    else if(member.IsMap || member.IsList)
                    {

            
            #line default
            #line hidden
            this.Write("            return this.");
            
            #line 107 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(" != null && this.");
            
            #line 107 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(".Count > 0; \r\n");
            
            #line 108 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

                    }
                    else
                    {

            
            #line default
            #line hidden
            this.Write("            return this.");
            
            #line 113 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(" != null;\r\n");
            
            #line 114 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

                    }

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 119 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

                }
            }
        }

            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 128 "C:\codebase\GitBranches\sdk.runtime\sdk\src\ServiceClientGenerator\Generators\StructureGenerator.tt"

    // Set to true when the service model specifies a shape that should be wrapped in a response. ElastiCache CreateCacheCluster is an example of this.
    public bool IsWrapped { get; set; }

	public Operation Operation { get; set; }
    public string ClassName { get; set; }
    public string BaseClass { get; set; }
    public Shape Structure { get; set; }
	public StructureType StructureType { get; set; }

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}