#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SilentNotes.Views
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#line 1 "NoteRepositoryRazorView.cshtml"
using SilentNotes.ViewModels;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "16.3.0.277")]
public partial class NoteRepositoryRazorView : NoteRepositoryRazorViewBase
{

#line hidden

#line 2 "NoteRepositoryRazorView.cshtml"
public NoteRepositoryViewModel Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(" />\r\n    <base");

WriteAttribute ("href", " href=\"", "\""

#line 7 "NoteRepositoryRazorView.cshtml"
, Tuple.Create<string,object,bool> ("", Model.HtmlBase

#line default
#line hidden
, false)
);
WriteLiteral(">\r\n    <title>SilentNotes</title>\r\n    <meta");

WriteLiteral(" charset=\"UTF-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1, shrink-to-fit=no, user-scalable=no" +
"\"");

WriteLiteral(">\r\n\r\n    <link");

WriteLiteral(" href=\"bootstrap.min.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"silentnotes.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n\r\n    <script");

WriteLiteral(" src=\"jquery-3.4.1.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"bootstrap.bundle.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"silentnotes.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"Sortable.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"jquery.longpress.js\"");

WriteLiteral("></script>\r\n\r\n    <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n        body {\r\n            background-color: ");


#line 23 "NoteRepositoryRazorView.cshtml"
                         Write(Model.Theme.ImageTint);


#line default
#line hidden
WriteLiteral(";\r\n            background: url(");


#line 24 "NoteRepositoryRazorView.cshtml"
                       Write(Model.Theme.Image);


#line default
#line hidden
WriteLiteral(");\r\n        }\r\n\r\n        .note-viewer {\r\n            font-size: ");


#line 28 "NoteRepositoryRazorView.cshtml"
                   Write(Model.NoteBaseFontSize);


#line default
#line hidden
WriteLiteral(@"px !important;
        }
        .note-viewer a {
            pointer-events: none; /* ignore clicks on links */
            cursor: default;
        }

        .nav-filter {
            margin: 0 1em 0 0;
            width: 200px;
            height: 28px;
            background-color: #FFFFFF;
            border-radius: 14px;
        }
        .nav-filter:hover {
            background-color: #FFFFFF;
        }
        .nav-filter input {
            margin: auto;
            width: 154px;
            left: 14px;
            border: none;
            border-width: 0;
            outline: none;
            background-color: transparent;
            color: #666666;
            font-size: 1.1em;
        }
    </style>
    <script>
    </script>
</head>
<body>
    <nav");

WriteLiteral(" id=\"navigation\"");

WriteLiteral(" class=\"d-flex\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"nav-item nav-filter ml-auto d-inline-flex align-self-center\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" oninput=\"bind(event)\"");

WriteLiteral(" data-binding=\"TxtFilter\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(" autofocus />\r\n            <svg");

WriteLiteral(" width=\'24\'");

WriteLiteral(" height=\'24\'");

WriteLiteral(" viewBox=\'0 0 24 24\'");

WriteLiteral(" data-binding=\"FilterButtonMagnifier\"");

WriteLiteral(" style=\"fill:#a8a8a8\"");

WriteLiteral(">");


#line 64 "NoteRepositoryRazorView.cshtml"
                                                                                                                        WriteLiteral(Model.Icon.LoadIconSvgPath("magnify"));

#line default
#line hidden
WriteLiteral("</svg>\r\n            <svg");

WriteLiteral(" width=\'24\'");

WriteLiteral(" height=\'24\'");

WriteLiteral(" viewBox=\'0 0 24 24\'");

WriteLiteral(" class=\"hidden-at-startup\"");

WriteLiteral(" onclick=\"bind(event)\"");

WriteLiteral(" data-binding=\"FilterButtonCancel\"");

WriteLiteral(" style=\"fill:#666666\"");

WriteLiteral(">");


#line 65 "NoteRepositoryRazorView.cshtml"
                                                                                                                                                                     WriteLiteral(Model.Icon.LoadIconSvgPath("close-circle-outline"));

#line default
#line hidden
WriteLiteral("</svg>\r\n        </div>\r\n\r\n        <button");

WriteLiteral(" class=\"nav-item show-only-on-wide-browser\"");

WriteLiteral(" onclick=\"bind(event);\"");

WriteLiteral(" data-binding=\"AddNote\"");

WriteAttribute ("title", " title=\"", "\""

#line 68 "NoteRepositoryRazorView.cshtml"
                                                                         , Tuple.Create<string,object,bool> ("", Model.Language["note_create_new"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 68 "NoteRepositoryRazorView.cshtml"
                                                                                                                                                      WriteLiteral(Model.Icon["plus"]);

#line default
#line hidden
WriteLiteral("</button>\r\n        <button");

WriteLiteral(" class=\"nav-item show-only-on-wide-browser\"");

WriteLiteral(" onclick=\"bind(event);\"");

WriteLiteral(" data-binding=\"ShowNote\"");

WriteAttribute ("title", " title=\"", "\""

#line 69 "NoteRepositoryRazorView.cshtml"
                                                                          , Tuple.Create<string,object,bool> ("", Model.Language["note_view_or_edit"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 69 "NoteRepositoryRazorView.cshtml"
                                                                                                                                                         WriteLiteral(Model.Icon["lead-pencil"]);

#line default
#line hidden
WriteLiteral("</button>\r\n        <button");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(" onclick=\"bind(event);\"");

WriteLiteral(" data-binding=\"DeleteNote\"");

WriteAttribute ("title", " title=\"", "\""

#line 70 "NoteRepositoryRazorView.cshtml"
                                                  , Tuple.Create<string,object,bool> ("", Model.Language["note_to_recyclebin"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 70 "NoteRepositoryRazorView.cshtml"
                                                                                                                                  WriteLiteral(Model.Icon["delete"]);

#line default
#line hidden
WriteLiteral("</button>\r\n        <button");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(" onclick=\"bind(event);\"");

WriteLiteral(" data-binding=\"Synchronize\"");

WriteAttribute ("title", " title=\"", "\""

#line 71 "NoteRepositoryRazorView.cshtml"
                                                   , Tuple.Create<string,object,bool> ("", Model.Language["sync_notes"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 71 "NoteRepositoryRazorView.cshtml"
                                                                                                                           WriteLiteral(Model.Icon["cloud-sync"]);

#line default
#line hidden
WriteLiteral("</button>\r\n\r\n        <div");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(" id=\"navOverflowMenu\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(">\r\n");


#line 75 "NoteRepositoryRazorView.cshtml"
                

#line default
#line hidden

#line 75 "NoteRepositoryRazorView.cshtml"
                  WriteLiteral(Model.Icon["dots-vertical"]);

#line default
#line hidden
WriteLiteral("\r\n            </button>\r\n            <div");

WriteLiteral(" class=\"dropdown-menu dropdown-menu-right\"");

WriteLiteral(" aria-labelledby=\"navOverflowMenu\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"dropdown-item show-only-on-narrow-browser\"");

WriteLiteral(" onclick=\"bind(event);\"");

WriteLiteral(" data-binding=\"AddNote\"");

WriteLiteral(">");


#line 78 "NoteRepositoryRazorView.cshtml"
                                                                                                                       WriteLiteral(Model.Icon["plus"]);

#line default
#line hidden
WriteLiteral(" ");


#line 78 "NoteRepositoryRazorView.cshtml"
                                                                                                                                                     Write(Model.Language["note_create_new"]);


#line default
#line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"dropdown-item show-only-on-narrow-browser\"");

WriteLiteral(" onclick=\"bind(event);\"");

WriteLiteral(" data-binding=\"ShowNote\"");

WriteLiteral(">");


#line 79 "NoteRepositoryRazorView.cshtml"
                                                                                                                        WriteLiteral(Model.Icon["lead-pencil"]);

#line default
#line hidden
WriteLiteral(" ");


#line 79 "NoteRepositoryRazorView.cshtml"
                                                                                                                                                             Write(Model.Language["note_view_or_edit"]);


#line default
#line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(" onclick=\"bind(event);\"");

WriteLiteral(" data-binding=\"ShowTransferCode\"");

WriteLiteral(">");


#line 80 "NoteRepositoryRazorView.cshtml"
                                                                                                    WriteLiteral(Model.Icon["key"]);

#line default
#line hidden
WriteLiteral(" ");


#line 80 "NoteRepositoryRazorView.cshtml"
                                                                                                                                 Write(Model.Language["show_transfer_code"]);


#line default
#line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(" onclick=\"bind(event);\"");

WriteLiteral(" data-binding=\"ShowRecycleBin\"");

WriteLiteral(">");


#line 81 "NoteRepositoryRazorView.cshtml"
                                                                                                  WriteLiteral(Model.Icon["delete-empty"]);

#line default
#line hidden
WriteLiteral(" ");


#line 81 "NoteRepositoryRazorView.cshtml"
                                                                                                                                        Write(Model.Language["show_recyclebin"]);


#line default
#line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(" onclick=\"bind(event);\"");

WriteLiteral(" data-binding=\"ShowSettings\"");

WriteLiteral(">");


#line 82 "NoteRepositoryRazorView.cshtml"
                                                                                                WriteLiteral(Model.Icon["settings"]);

#line default
#line hidden
WriteLiteral(" ");


#line 82 "NoteRepositoryRazorView.cshtml"
                                                                                                                                  Write(Model.Language["show_settings"]);


#line default
#line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(" onclick=\"bind(event);\"");

WriteLiteral(" data-binding=\"ShowInfo\"");

WriteLiteral(">");


#line 83 "NoteRepositoryRazorView.cshtml"
                                                                                            WriteLiteral(Model.Icon["information"]);

#line default
#line hidden
WriteLiteral(" ");


#line 83 "NoteRepositoryRazorView.cshtml"
                                                                                                                                 Write(Model.Language["show_info"]);


#line default
#line hidden
WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n\r\n    <div");

WriteLiteral(" class=\"fab\"");

WriteLiteral("><a");

WriteLiteral(" onclick=\"bind(event);\"");

WriteLiteral(" data-binding=\"Fab\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">");


#line 88 "NoteRepositoryRazorView.cshtml"
                                                                             WriteLiteral(Model.Icon["plus"]);

#line default
#line hidden
WriteLiteral("</a></div>\r\n\r\n    <div");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"p-2\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" id=\"note-repository\"");

WriteLiteral("></ul>\r\n    </div>\r\n</body>\r\n</html>\r\n");

}
}

// NOTE: this is the default generated helper class. You may choose to extract it to a separate file 
// in order to customize it or share it between multiple templates, and specify the template's base 
// class via the @inherits directive.
public abstract class NoteRepositoryRazorViewBase
{

		// This field is OPTIONAL, but used by the default implementation of Generate, Write, WriteAttribute and WriteLiteral
		//
		System.IO.TextWriter __razor_writer;

		// This method is OPTIONAL
		//
		/// <summary>Executes the template and returns the output as a string.</summary>
		/// <returns>The template output.</returns>
		public string GenerateString ()
		{
			using (var sw = new System.IO.StringWriter ()) {
				Generate (sw);
				return sw.ToString ();
			}
		}

		// This method is OPTIONAL, you may choose to implement Write and WriteLiteral without use of __razor_writer
		// and provide another means of invoking Execute.
		//
		/// <summary>Executes the template, writing to the provided text writer.</summary>
		/// <param name="writer">The TextWriter to which to write the template output.</param>
		public void Generate (System.IO.TextWriter writer)
		{
			__razor_writer = writer;
			Execute ();
			__razor_writer = null;
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the template output without HTML escaping it.</summary>
		/// <param name="value">The literal value.</param>
		protected void WriteLiteral (string value)
		{
			__razor_writer.Write (value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the TextWriter without HTML escaping it.</summary>
		/// <param name="writer">The TextWriter to which to write the literal.</param>
		/// <param name="value">The literal value.</param>
		protected static void WriteLiteralTo (System.IO.TextWriter writer, string value)
		{
			writer.Write (value);
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a value to the template output, HTML escaping it if necessary.</summary>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected void Write (object value)
		{
			WriteTo (__razor_writer, value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes an object value to the TextWriter, HTML escaping it if necessary.</summary>
		/// <param name="writer">The TextWriter to which to write the value.</param>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected static void WriteTo (System.IO.TextWriter writer, object value)
		{
			if (value == null)
				return;

			var write = value as Action<System.IO.TextWriter>;
			if (write != null) {
				write (writer);
				return;
			}

			//NOTE: a more sophisticated implementation would write safe and pre-escaped values directly to the
			//instead of double-escaping. See System.Web.IHtmlString in ASP.NET 4.0 for an example of this.
			writer.Write(System.Net.WebUtility.HtmlEncode (value.ToString ()));
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to the template output.
		/// </summary>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		protected void WriteAttribute (string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			WriteAttributeTo (__razor_writer, name, prefix, suffix, values);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to a TextWriter.
		/// </summary>
		/// <param name="writer">The TextWriter to which to write the attribute.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		///<remarks>Used by Razor helpers to write attributes.</remarks>
		protected static void WriteAttributeTo (System.IO.TextWriter writer, string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			// this is based on System.Web.WebPages.WebPageExecutingBase
			// Copyright (c) Microsoft Open Technologies, Inc.
			// Licensed under the Apache License, Version 2.0
			if (values.Length == 0) {
				// Explicitly empty attribute, so write the prefix and suffix
				writer.Write (prefix);
				writer.Write (suffix);
				return;
			}

			bool first = true;
			bool wroteSomething = false;

			for (int i = 0; i < values.Length; i++) {
				Tuple<string,object,bool> attrVal = values [i];
				string attPrefix = attrVal.Item1;
				object value = attrVal.Item2;
				bool isLiteral = attrVal.Item3;

				if (value == null) {
					// Nothing to write
					continue;
				}

				// The special cases here are that the value we're writing might already be a string, or that the
				// value might be a bool. If the value is the bool 'true' we want to write the attribute name instead
				// of the string 'true'. If the value is the bool 'false' we don't want to write anything.
				//
				// Otherwise the value is another object (perhaps an IHtmlString), and we'll ask it to format itself.
				string stringValue;
				bool? boolValue = value as bool?;
				if (boolValue == true) {
					stringValue = name;
				} else if (boolValue == false) {
					continue;
				} else {
					stringValue = value as string;
				}

				if (first) {
					writer.Write (prefix);
					first = false;
				} else {
					writer.Write (attPrefix);
				}

				if (isLiteral) {
					writer.Write (stringValue ?? value);
				} else {
					WriteTo (writer, stringValue ?? value);
				}
				wroteSomething = true;
			}
			if (wroteSomething) {
				writer.Write (suffix);
			}
		}
		// This method is REQUIRED. The generated Razor subclass will override it with the generated code.
		//
		///<summary>Executes the template, writing output to the Write and WriteLiteral methods.</summary>.
		///<remarks>Not intended to be called directly. Call the Generate method instead.</remarks>
		public abstract void Execute ();

}
}
#pragma warning restore 1591
