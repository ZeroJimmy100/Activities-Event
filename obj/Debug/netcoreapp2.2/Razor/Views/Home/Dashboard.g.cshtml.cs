#pragma checksum "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4420436136d85b86bb22f8147d3e8cbca94d072"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\_ViewImports.cshtml"
using ActivitiesEvent;

#line default
#line hidden
#line 2 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\_ViewImports.cshtml"
using ActivitiesEvent.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4420436136d85b86bb22f8147d3e8cbca94d072", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16978cf4784f153514390e38930f50f412cf5d06", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WrapperViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AttendEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UnAttendEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(62, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4420436136d85b86bb22f8147d3e8cbca94d0725790", async() => {
                BeginContext(68, 136, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Dashboard</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(211, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(213, 2851, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4420436136d85b86bb22f8147d3e8cbca94d0727119", async() => {
                BeginContext(219, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(225, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4420436136d85b86bb22f8147d3e8cbca94d0727505", async() => {
                    BeginContext(287, 54, true);
                    WriteLiteral("\r\n        <input type=\"submit\" value=\"Log out\"/>\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(348, 55, true);
                WriteLiteral("\r\n    <h1>Welcome to Coding Dojo Event</h1>\r\n    <h3><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 403, "\"", 441, 2);
                WriteAttributeValue("", 410, "/AddEvent/", 410, 10, true);
#line 15 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 420, Model.NewUser.UserId, 420, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(442, 319, true);
                WriteLiteral(@">Add an Event</a></h3>

    <table class=""table table-striped"">
            <tr>
                <th>Title </th>
                <th>Creator </th>
                <th>Date Time </th>
                <th>Duration </th>
                <th>Participants </th>
                <th>Action </th>
            </tr>
");
                EndContext();
#line 26 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
         foreach(FormEvent e in @Model.ListEvents){
            var timezone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
           string EventDate = TimeZoneInfo.ConvertTime(@e.Date, timezone).ToString("dddd, MMMM, dd, HH:MM tt");
           
           DateTime Today = DateTime.Now;
           string TodayDate = Today.ToString("dddd, MMMM, dd");
           int result = DateTime.Compare(@e.Date, Today);

           
           if(result > 0){

#line default
#line hidden
                BeginContext(1240, 48, true);
                WriteLiteral("                <tr>\r\n                    <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1288, "\"", 1338, 4);
                WriteAttributeValue("", 1295, "/Event/", 1295, 7, true);
#line 37 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1302, e.EventFormId, 1302, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 1316, "/", 1316, 1, true);
#line 37 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1317, Model.NewUser.UserId, 1317, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1339, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1341, 7, false);
#line 37 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                                                                         Write(e.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1348, 35, true);
                WriteLiteral("</a></td>\r\n                    <td>");
                EndContext();
                BeginContext(1384, 22, false);
#line 38 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                   Write(e.ThePlanner.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1406, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1408, 21, false);
#line 38 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                                           Write(e.ThePlanner.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(1429, 79, true);
                WriteLiteral("</td>\r\n                    \r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1509, 9, false);
#line 41 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                   Write(EventDate);

#line default
#line hidden
                EndContext();
                BeginContext(1518, 55, true);
                WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>");
                EndContext();
                BeginContext(1574, 15, false);
#line 44 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                   Write(e.EventDuration);

#line default
#line hidden
                EndContext();
                BeginContext(1589, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1591, 10, false);
#line 44 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                                    Write(e.Duration);

#line default
#line hidden
                EndContext();
                BeginContext(1601, 33, true);
                WriteLiteral("</td>\r\n\r\n                    <td>");
                EndContext();
                BeginContext(1635, 17, false);
#line 46 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                   Write(e.Attending.Count);

#line default
#line hidden
                EndContext();
                BeginContext(1652, 53, true);
                WriteLiteral("</td>\r\n                    \r\n                    <td>");
                EndContext();
#line 48 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                         if(e.UserId == @Model.NewUser.UserId){

#line default
#line hidden
                BeginContext(1746, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1770, 246, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4420436136d85b86bb22f8147d3e8cbca94d07215311", async() => {
                    BeginContext(1916, 93, true);
                    WriteLiteral("\r\n                            <input type=\"submit\" value=\"Delete\"/>\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-EventFormId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 49 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                                                                                                     WriteLiteral(e.EventFormId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["EventFormId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-EventFormId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["EventFormId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 49 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                                                                                                                                       WriteLiteral(Model.NewUser.UserId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["UserId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["UserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2016, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 52 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                        
                    }
                    

#line default
#line hidden
                BeginContext(2157, 20, true);
                WriteLiteral("                    ");
                EndContext();
#line 55 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                     if(!e.Attending.Any(a => a.UserId == @Model.NewUser.UserId)){

#line default
#line hidden
                BeginContext(2241, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(2265, 245, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4420436136d85b86bb22f8147d3e8cbca94d07220118", async() => {
                    BeginContext(2412, 91, true);
                    WriteLiteral("\r\n                            <input type=\"submit\" value=\"Join\"/>\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-EventFormId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 56 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                                                                                                      WriteLiteral(e.EventFormId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["EventFormId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-EventFormId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["EventFormId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 56 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                                                                                                                                        WriteLiteral(Model.NewUser.UserId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["UserId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["UserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2510, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 59 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                    }
                    else if(e.Attending.Any(a => a.UserId == @Model.NewUser.UserId)){

#line default
#line hidden
                BeginContext(2622, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(2646, 248, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4420436136d85b86bb22f8147d3e8cbca94d07224625", async() => {
                    BeginContext(2795, 92, true);
                    WriteLiteral("\r\n                            <input type=\"submit\" value=\"Leave\"/>\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-EventFormId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 61 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                                                                                                        WriteLiteral(e.EventFormId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["EventFormId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-EventFormId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["EventFormId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 61 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                                                                                                                                          WriteLiteral(Model.NewUser.UserId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["UserId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["UserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2894, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 64 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                    }

#line default
#line hidden
                BeginContext(2919, 50, true);
                WriteLiteral("                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 67 "C:\Users\JP\Documents\CD C#\C#Belt\ActivitiesEvent\Views\Home\Dashboard.cshtml"
                    
           }else{

           }
        }

#line default
#line hidden
                BeginContext(3037, 20, true);
                WriteLiteral("        </table>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3064, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WrapperViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
