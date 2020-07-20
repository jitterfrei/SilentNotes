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

#line 1 "NoteRazorView.cshtml"
using SilentNotes.ViewModels;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "16.6.0.1062")]
public partial class NoteRazorView : NoteRazorViewBase
{

#line hidden

#line 2 "NoteRazorView.cshtml"
public NoteViewModel Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(" />\r\n    <base");

WriteAttribute ("href", " href=\"", "\""

#line 7 "NoteRazorView.cshtml"
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

WriteLiteral(" />\r\n    <link");

WriteAttribute ("href", " href=\"", "\""

#line 14 "NoteRazorView.cshtml"
, Tuple.Create<string,object,bool> ("", Model.Theme.DarkMode ? "silentnotes.dark.css" : "silentnotes.light.css"

#line default
#line hidden
, false)
);
WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n\r\n    <link");

WriteLiteral(" href=\"quill/quill.snow.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" href=\"note-view.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" href=\"quillsearchhighlighter.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n\r\n    <script");

WriteLiteral(" src=\"vue.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"jquery-3.5.1.slim.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"bootstrap.bundle.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"silentnotes.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"quill/quill.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"quillsearchhighlighter.js\"");

WriteLiteral("></script>\r\n\r\n    <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\nbody { background-color: transparent; }\r\n\r\n.note-viewer {\r\n    font-size: ");


#line 31 "NoteRazorView.cshtml"
           Write(Model.NoteBaseFontSize);


#line default
#line hidden
WriteLiteral("px !important;\r\n}\r\n.color-btn { color: black; }\r\n.color-btn.dark { color: white; " +
"}\r\n.locked {\r\n    position: relative;\r\n    height: 100%;\r\n}\r\n.locked svg {\r\n    " +
"fill: rgba(160, 160, 160, 0.4);\r\n}\r\n    </style>\r\n    <script>\r\n        var quil" +
"l;\r\n        var searchHighlighter;\r\n\r\n        function toggleFormat(formatName) " +
"{\r\n            var selectionFormat = quill.getFormat();\r\n            var selecti" +
"onFormatValue = selectionFormat[formatName];\r\n            selectionFormatValue =" +
" !selectionFormatValue;\r\n            quill.format(formatName, selectionFormatVal" +
"ue, \'user\');\r\n        }\r\n\r\n        function toggleBlockFormat(formatName, blockT" +
"ype) {\r\n            var selectionFormat = quill.getFormat();\r\n            var se" +
"lectionFormatValue = selectionFormat[formatName];\r\n            var newSelectionF" +
"ormat; // undefined removes the block format\r\n            if (selectionFormatVal" +
"ue !== blockType)\r\n                newSelectionFormat = blockType;\r\n            " +
"quill.format(formatName, newSelectionFormat, \'user\');\r\n        }\r\n\r\n        func" +
"tion toggleLink() {\r\n            var selectionFormat = quill.getFormat();\r\n     " +
"       var selectionFormatValue = selectionFormat[\'link\'];\r\n            var tool" +
"bar = quill.getModule(\'toolbar\');\r\n            toolbar.handlers[\'link\'].call(too" +
"lbar, !selectionFormatValue);\r\n        }\r\n\r\n        function getNoteHtmlContent(" +
") {\r\n            return quill.root.innerHTML;\r\n        }\r\n\r\n        function set" +
"NoteHtmlContent(text) {\r\n            quill.setText(text, \'user\');\r\n        }\r\n\r\n" +
"        function toggleSearchDialog() {\r\n            var makeVisible = $(\'#searc" +
"h-dialog\').hasClass(\'hidden\');\r\n            showSearchDialog(makeVisible);\r\n    " +
"    }\r\n\r\n        function showSearchDialog(visible) {\r\n            if (visible) " +
"{\r\n                // Open dialog\r\n                $(\'#search-dialog\').removeCla" +
"ss(\'hidden\');\r\n                $(\'#TxtFilter\').focus();\r\n                searchH" +
"ighlighter.startListening();\r\n            }\r\n            else {\r\n               " +
" // Close dialog\r\n                searchHighlighter.stopListening();\r\n          " +
"      searchHighlighter.clearSearchHighlights();\r\n                $(\'#search-dia" +
"log\').addClass(\'hidden\');\r\n                $(\'#TxtFilter\').val(\'\');\r\n           " +
" }\r\n        }\r\n\r\n        function scrollToTop() {\r\n            var element = qui" +
"ll.root;\r\n            element.scrollTop = 0;\r\n        }\r\n\r\n        function scro" +
"llToBottom() {\r\n            var element = quill.root;\r\n            element.scrol" +
"lTop = element.scrollHeight;\r\n        }\r\n\r\n        $(function () {\r\n            " +
"quill = new Quill(\'#myeditor\', {\r\n                formats: [\'header\', \'bold\', \'i" +
"talic\', \'underline\', \'strike\', \'list\', \'code\', \'code-block\', \'blockquote\', \'link" +
"\'],\r\n                modules: {\r\n                    toolbar: \'#quill-toolbar\',\r" +
"\n                },\r\n                theme: \'snow\',\r\n            });\r\n\r\n        " +
"    quill.on(\'text-change\', function (delta, oldDelta, source) {\r\n              " +
"  if (source === \'user\') {\r\n                    vuePropertyChanged(\'UnlockedHtml" +
"Content\', null);\r\n                }\r\n            });\r\n\r\n            // This way " +
"we can remove the tel:// protocol\r\n            var Link = Quill.import(\'formats/" +
"link\');\r\n            Link.PROTOCOL_WHITELIST = [\'http\', \'https\', \'mailto\'];\r\n\r\n " +
"           searchHighlighter = new QuillSearchHighlighter(quill, document.getEle" +
"mentById(\"TxtFilter\"));\r\n\r\n            var noteContent = getNoteHtmlContent();\r\n" +
"            var noteIsNew = noteContent.length > 1 && noteContent.length < 42 &&" +
" noteContent.replace(/<[^>]*>/g, \'\').trim().length == 0;\r\n            if (noteIs" +
"New) {\r\n                toggleBlockFormat(\'header\', 1);\r\n            }\r\n        " +
"});\r\n\r\n");


#line 137 "NoteRazorView.cshtml"
        

#line default
#line hidden

#line 137 "NoteRazorView.cshtml"
          WriteLiteral(Model.VueDataBindingScript);

#line default
#line hidden
WriteLiteral("\r\n    </script>\r\n</head>\r\n<body><div");

WriteLiteral(" id=\"vueDataBinding\"");

WriteLiteral(">\r\n    <nav");

WriteLiteral(" id=\"navigation\"");

WriteLiteral(" class=\"d-flex\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" class=\"nav-item mr-auto\"");

WriteLiteral(" v-on:click=\"GoBackCommand\"");

WriteAttribute ("title", " title=\"", "\""

#line 142 "NoteRazorView.cshtml"
                                    , Tuple.Create<string,object,bool> ("", Model.Language["back"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 142 "NoteRazorView.cshtml"
                                                                                                      WriteLiteral(Model.Icon["arrow-left"]);

#line default
#line hidden
WriteLiteral("</button>\r\n\r\n        <span");

WriteLiteral(" id=\"quill-toolbar\"");

WriteLiteral(" class=\"d-inline-flex\"");

WriteLiteral(">\r\n");


#line 145 "NoteRazorView.cshtml"
            

#line default
#line hidden

#line 145 "NoteRazorView.cshtml"
             if (!Model.IsLocked)
            {


#line default
#line hidden
WriteLiteral("                <select");

WriteLiteral(" class=\"nav-item ql-header\"");

WriteLiteral(">\r\n                    <option");

WriteLiteral(" value=\"1\"");

WriteLiteral("></option>\r\n                    <option");

WriteLiteral(" value=\"2\"");

WriteLiteral("></option>\r\n                    <option");

WriteLiteral(" value=\"3\"");

WriteLiteral("></option>\r\n                    <option");

WriteLiteral(" selected=\"selected\"");

WriteLiteral("></option>\r\n                </select>\r\n");


#line 153 "NoteRazorView.cshtml"



#line default
#line hidden
WriteLiteral("                <button");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(" onclick=\"toggleSearchDialog(); return false;\"");

WriteAttribute ("title", " title=\"", "\""

#line 154 "NoteRazorView.cshtml"
                                                       , Tuple.Create<string,object,bool> ("", Model.Language["search"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 154 "NoteRazorView.cshtml"
                                                                                                                           WriteLiteral(Model.Icon["magnify"]);

#line default
#line hidden
WriteLiteral("</button>\r\n");


#line 155 "NoteRazorView.cshtml"



#line default
#line hidden
WriteLiteral("                <button");

WriteLiteral(" class=\"nav-item ql-bold\"");

WriteAttribute ("title", " title=\"", "\""

#line 156 "NoteRazorView.cshtml"
                 , Tuple.Create<string,object,bool> ("", Model.Language["note_bold"]

#line default
#line hidden
, false)
);
WriteLiteral("></button>\r\n");

WriteLiteral("                <button");

WriteLiteral(" class=\"nav-item ql-italic\"");

WriteAttribute ("title", " title=\"", "\""

#line 157 "NoteRazorView.cshtml"
                   , Tuple.Create<string,object,bool> ("", Model.Language["note_italic"]

#line default
#line hidden
, false)
);
WriteLiteral("></button>\r\n");

WriteLiteral("                <span");

WriteLiteral(" class=\"show-only-on-wide-browser\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" class=\"nav-item ql-underline\"");

WriteAttribute ("title", " title=\"", "\""

#line 159 "NoteRazorView.cshtml"
                          , Tuple.Create<string,object,bool> ("", Model.Language["note_underline"]

#line default
#line hidden
, false)
);
WriteLiteral("></button>\r\n                    <button");

WriteLiteral(" class=\"nav-item ql-strike\"");

WriteAttribute ("title", " title=\"", "\""

#line 160 "NoteRazorView.cshtml"
                       , Tuple.Create<string,object,bool> ("", Model.Language["note_strike"]

#line default
#line hidden
, false)
);
WriteLiteral("></button>\r\n                    <button");

WriteLiteral(" class=\"nav-item ql-list\"");

WriteLiteral(" value=\"ordered\"");

WriteAttribute ("title", " title=\"", "\""

#line 161 "NoteRazorView.cshtml"
                                     , Tuple.Create<string,object,bool> ("", Model.Language["note_list_ordered"]

#line default
#line hidden
, false)
);
WriteLiteral("></button>\r\n                    <button");

WriteLiteral(" class=\"nav-item ql-list\"");

WriteLiteral(" value=\"bullet\"");

WriteAttribute ("title", " title=\"", "\""

#line 162 "NoteRazorView.cshtml"
                                    , Tuple.Create<string,object,bool> ("", Model.Language["note_list_unordered"]

#line default
#line hidden
, false)
);
WriteLiteral("></button>\r\n                </span>\r\n");


#line 164 "NoteRazorView.cshtml"
            }


#line default
#line hidden
WriteLiteral("        </span>\r\n\r\n        <!-- Color dropdown -->\r\n        <div");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n");


#line 169 "NoteRazorView.cshtml"
            

#line default
#line hidden

#line 169 "NoteRazorView.cshtml"
             if (!Model.IsLocked)
            {


#line default
#line hidden
WriteLiteral("                <button");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(" id=\"colorDropdownMenu\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteAttribute ("title", " title=\"", "\""

#line 171 "NoteRazorView.cshtml"
                                                                                                  , Tuple.Create<string,object,bool> ("", Model.Language["note_colors"]

#line default
#line hidden
, false)
);
WriteLiteral(">\r\n");


#line 172 "NoteRazorView.cshtml"
                    

#line default
#line hidden

#line 172 "NoteRazorView.cshtml"
                      WriteLiteral(Model.Icon["palette"]);

#line default
#line hidden
WriteLiteral("\r\n                </button>\r\n");


#line 174 "NoteRazorView.cshtml"
            }


#line default
#line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"dropdown-menu dropdown-menu-right\"");

WriteLiteral(" aria-labelledby=\"colorDropdownMenu\"");

WriteLiteral(">\r\n");


#line 176 "NoteRazorView.cshtml"
                

#line default
#line hidden

#line 176 "NoteRazorView.cshtml"
                 foreach (var backgroundColor in @Model.BackgroundColorsHex)
                {


#line default
#line hidden
WriteLiteral("                    <div");

WriteAttribute ("class", " class=\"", "\""
, Tuple.Create<string,object,bool> ("", "dropdown-item", true)
, Tuple.Create<string,object,bool> (" ", "color-btn", true)

#line 178 "NoteRazorView.cshtml"
                , Tuple.Create<string,object,bool> (" ", Model.GetDarkClass(backgroundColor)

#line default
#line hidden
, false)
);
WriteAttribute ("v-on:click", " v-on:click=\"", "\""
, Tuple.Create<string,object,bool> ("", "BackgroundColorHex=\'", true)

#line 178 "NoteRazorView.cshtml"
                                                                                        , Tuple.Create<string,object,bool> ("", backgroundColor

#line default
#line hidden
, false)
, Tuple.Create<string,object,bool> ("", "\'", true)
);
WriteAttribute ("style", " style=\"", "\""
, Tuple.Create<string,object,bool> ("", "background-color:", true)

#line 178 "NoteRazorView.cshtml"
                                                                                                                                    , Tuple.Create<string,object,bool> (" ", backgroundColor

#line default
#line hidden
, false)
);
WriteLiteral(">Lorem ipsum</div>\r\n");


#line 179 "NoteRazorView.cshtml"
                }


#line default
#line hidden
WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <!-- Dropdown Menu -->\r\n");


#line 184 "NoteRazorView.cshtml"
        

#line default
#line hidden

#line 184 "NoteRazorView.cshtml"
         if (!Model.IsLocked)
        {


#line default
#line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(" id=\"navOverflowMenu\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(">\r\n");


#line 188 "NoteRazorView.cshtml"
                    

#line default
#line hidden

#line 188 "NoteRazorView.cshtml"
                      WriteLiteral(Model.Icon["dots-vertical"]);

#line default
#line hidden
WriteLiteral("\r\n                </button>\r\n                <div");

WriteLiteral(" class=\"dropdown-menu dropdown-menu-right\"");

WriteLiteral(" aria-labelledby=\"navOverflowMenu\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"dropdown-item show-only-on-narrow-browser\"");

WriteLiteral(" onclick=\"toggleFormat(\'underline\');\"");

WriteLiteral(">");


#line 191 "NoteRazorView.cshtml"
                                                                                                                  WriteLiteral(Model.Icon["format-underline"]);

#line default
#line hidden
WriteLiteral(" ");


#line 191 "NoteRazorView.cshtml"
                                                                                                                                                            Write(Model.Language["note_underline"]);


#line default
#line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"dropdown-item show-only-on-narrow-browser\"");

WriteLiteral(" onclick=\"toggleFormat(\'strike\');\"");

WriteLiteral(">");


#line 192 "NoteRazorView.cshtml"
                                                                                                               WriteLiteral(Model.Icon["format-strikethrough-variant"]);

#line default
#line hidden
WriteLiteral(" ");


#line 192 "NoteRazorView.cshtml"
                                                                                                                                                                     Write(Model.Language["note_strike"]);


#line default
#line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"dropdown-item show-only-on-narrow-browser\"");

WriteLiteral(" onclick=\"toggleBlockFormat(\'list\', \'ordered\');\"");

WriteLiteral(">");


#line 193 "NoteRazorView.cshtml"
                                                                                                                             WriteLiteral(Model.Icon["format-list-numbers"]);

#line default
#line hidden
WriteLiteral(" ");


#line 193 "NoteRazorView.cshtml"
                                                                                                                                                                          Write(Model.Language["note_list_ordered"]);


#line default
#line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"dropdown-item show-only-on-narrow-browser\"");

WriteLiteral(" onclick=\"toggleBlockFormat(\'list\', \'bullet\');\"");

WriteLiteral(">");


#line 194 "NoteRazorView.cshtml"
                                                                                                                            WriteLiteral(Model.Icon["format-list-bulleted"]);

#line default
#line hidden
WriteLiteral(" ");


#line 194 "NoteRazorView.cshtml"
                                                                                                                                                                          Write(Model.Language["note_list_unordered"]);


#line default
#line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(" onclick=\"toggleFormat(\'code-block\');\"");

WriteLiteral(">");


#line 195 "NoteRazorView.cshtml"
                                                                                       WriteLiteral(Model.Icon["code-braces"]);

#line default
#line hidden
WriteLiteral(" ");


#line 195 "NoteRazorView.cshtml"
                                                                                                                            Write(Model.Language["note_code"]);


#line default
#line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(" onclick=\"toggleFormat(\'blockquote\');\"");

WriteLiteral(">");


#line 196 "NoteRazorView.cshtml"
                                                                                       WriteLiteral(Model.Icon["format-quote-close"]);

#line default
#line hidden
WriteLiteral(" ");


#line 196 "NoteRazorView.cshtml"
                                                                                                                                   Write(Model.Language["note_quotation"]);


#line default
#line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(" onclick=\"toggleLink()\"");

WriteLiteral(">");


#line 197 "NoteRazorView.cshtml"
                                                                        WriteLiteral(Model.Icon["link-variant"]);

#line default
#line hidden
WriteLiteral(" ");


#line 197 "NoteRazorView.cshtml"
                                                                                                              Write(Model.Language["note_link"]);


#line default
#line hidden
WriteLiteral("</div>\r\n");


#line 198 "NoteRazorView.cshtml"
                    

#line default
#line hidden

#line 198 "NoteRazorView.cshtml"
                     if (Model.ShowManualSynchronization)
                    {


#line default
#line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"dropdown-divider\"");

WriteLiteral("></div>\r\n");

WriteLiteral("                        <div");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(" v-on:click=\"PushNoteToOnlineStorageCommand\"");

WriteLiteral(">");


#line 201 "NoteRazorView.cshtml"
                                                                                                 WriteLiteral(Model.Icon["cloud-upload"]);

#line default
#line hidden
WriteLiteral(" ");


#line 201 "NoteRazorView.cshtml"
                                                                                                                                       Write(Model.Language["note_push_to_server"]);


#line default
#line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                        <div");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(" v-on:click=\"PullNoteFromOnlineStorageCommand\"");

WriteLiteral(">");


#line 202 "NoteRazorView.cshtml"
                                                                                                   WriteLiteral(Model.Icon["cloud-download"]);

#line default
#line hidden
WriteLiteral(" ");


#line 202 "NoteRazorView.cshtml"
                                                                                                                                           Write(Model.Language["note_pull_from_server"]);


#line default
#line hidden
WriteLiteral("</div>\r\n");


#line 203 "NoteRazorView.cshtml"
                    }


#line default
#line hidden
WriteLiteral("                </div>\r\n            </div>\r\n");


#line 206 "NoteRazorView.cshtml"
        }


#line default
#line hidden
WriteLiteral("    </nav>\r\n\r\n    <div");

WriteLiteral(" id=\"content\"");

WriteLiteral(" v-bind:class=\"{ dark: IsDark }\"");

WriteLiteral(" v-bind:style=\"{ backgroundColor: BackgroundColorHex }\"");

WriteLiteral(">\r\n");


#line 210 "NoteRazorView.cshtml"
        

#line default
#line hidden

#line 210 "NoteRazorView.cshtml"
         if (Model.IsLocked)
        {


#line default
#line hidden
WriteLiteral("            <span");

WriteLiteral(" class=\"locked d-flex justify-content-center align-items-center\"");

WriteLiteral(" v-bind:class=\"{ dark: IsDark }\"");

WriteLiteral("><svg");

WriteLiteral(" width=\'128\'");

WriteLiteral(" height=\'128\'");

WriteLiteral(" viewBox=\'0 0 24 24\'");

WriteLiteral("><use");

WriteLiteral(" xlink:href=\"#svg-lock-outline\"");

WriteLiteral(" /></svg></span>\r\n");


#line 213 "NoteRazorView.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"myeditor\"");

WriteAttribute ("class", " class=\"", "\""
, Tuple.Create<string,object,bool> ("", "note-viewer", true)
, Tuple.Create<string,object,bool> (" ", "detail-view", true)

#line 216 "NoteRazorView.cshtml"
                      , Tuple.Create<string,object,bool> (" ", Model.CssClassNoteType

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 216 "NoteRazorView.cshtml"
                                                                                         WriteLiteral(Model.UnlockedHtmlContent);

#line default
#line hidden
WriteLiteral("</div>\r\n");


#line 217 "NoteRazorView.cshtml"
        }


#line default
#line hidden
WriteLiteral("    </div>\r\n\r\n    <div");

WriteLiteral(" id=\"search-dialog\"");

WriteLiteral(" class=\"hidden\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"nav-filter\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" id=\"TxtFilter\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(" />\r\n            <svg");

WriteLiteral(" id=\"filter-cancel-icon\"");

WriteLiteral(" width=\'24\'");

WriteLiteral(" height=\'24\'");

WriteLiteral(" viewBox=\'0 0 24 24\'");

WriteLiteral(" class=\"\"");

WriteLiteral(" onclick=\"showSearchDialog(false);\"");

WriteLiteral("><use");

WriteLiteral(" xlink:href=\"#svg-close-circle-outline\"");

WriteLiteral(" /></svg>\r\n        </div>\r\n    </div>\r\n\r\n    <div hidden>\r\n");


#line 228 "NoteRazorView.cshtml"
        

#line default
#line hidden

#line 228 "NoteRazorView.cshtml"
          WriteLiteral(Model.Icon.LoadIcon("lock-outline", new[] { new KeyValuePair<string, string>("id", "svg-lock-outline") }));

#line default
#line hidden
WriteLiteral("\r\n");


#line 229 "NoteRazorView.cshtml"
        

#line default
#line hidden

#line 229 "NoteRazorView.cshtml"
          WriteLiteral(Model.Icon.LoadIcon("close-circle-outline", new[] { new KeyValuePair<string, string>("id", "svg-close-circle-outline") }));

#line default
#line hidden
WriteLiteral("\r\n    </div>\r\n</div></body>\r\n</html>\r\n");

}
}

// NOTE: this is the default generated helper class. You may choose to extract it to a separate file 
// in order to customize it or share it between multiple templates, and specify the template's base 
// class via the @inherits directive.
public abstract class NoteRazorViewBase
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
