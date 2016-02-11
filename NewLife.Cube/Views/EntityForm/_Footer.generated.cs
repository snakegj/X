﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 1 "..\..\Views\EntityForm\_Footer.cshtml"
    using NewLife.Cube;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EntityForm/_Footer.cshtml")]
    public partial class _Views_EntityForm__Footer_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_EntityForm__Footer_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\EntityForm\_Footer.cshtml"
  
    var entity = Model as IEntity;
    var fact = EntityFactory.CreateOperate(entity.GetType());

    var user = Model as IUserInfo;
    var time = Model as ITimeInfo;
    var cip = fact.Table.FindByName("CreateIP");
    var uip = fact.Table.FindByName("UpdateIP");
    var remark = fact.Table.FindByName("Remark");
    if (Object.Equals(remark, null)) { remark = fact.Table.FindByName("Description"); }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..\Views\EntityForm\_Footer.cshtml"
 if (user != null || time != null)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">创建</label>\r\n        <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n");

            
            #line 18 "..\..\Views\EntityForm\_Footer.cshtml"
            
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\EntityForm\_Footer.cshtml"
             if (user != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"text-primary\"");

WriteLiteral(">");

            
            #line 20 "..\..\Views\EntityForm\_Footer.cshtml"
                                      Write(user.CreateUserName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 21 "..\..\Views\EntityForm\_Footer.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 22 "..\..\Views\EntityForm\_Footer.cshtml"
             if (time != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 24 "..\..\Views\EntityForm\_Footer.cshtml"
                                      Write(time.CreateTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 25 "..\..\Views\EntityForm\_Footer.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 26 "..\..\Views\EntityForm\_Footer.cshtml"
             if (!Object.Equals(cip, null))
            {
                var ip = entity[cip.Name] + "";

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"text-primary\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1031), Tuple.Create("\"", 1042)
            
            #line 29 "..\..\Views\EntityForm\_Footer.cshtml"
, Tuple.Create(Tuple.Create("", 1039), Tuple.Create<System.Object, System.Int32>(ip
            
            #line default
            #line hidden
, 1039), false)
);

WriteLiteral(">");

            
            #line 29 "..\..\Views\EntityForm\_Footer.cshtml"
                                                  Write(ip.IPToAddress());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 30 "..\..\Views\EntityForm\_Footer.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 31 "..\..\Views\EntityForm\_Footer.cshtml"
             if (!Object.Equals(remark, null))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">");

            
            #line 34 "..\..\Views\EntityForm\_Footer.cshtml"
                                                     Write(remark.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <div");

WriteLiteral(" class=\"input-group col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 36 "..\..\Views\EntityForm\_Footer.cshtml"
                   Write(Html.ForString(remark.Name, (String)entity[remark.Name], -1));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 37 "..\..\Views\EntityForm\_Footer.cshtml"
                   Write(Html.ForDescription(remark));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

            
            #line 40 "..\..\Views\EntityForm\_Footer.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n        <label");

WriteLiteral(" class=\"control-label col-md-1\"");

WriteLiteral(">更新</label>\r\n        <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n");

            
            #line 44 "..\..\Views\EntityForm\_Footer.cshtml"
            
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\EntityForm\_Footer.cshtml"
             if (user != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"text-primary\"");

WriteLiteral(">");

            
            #line 46 "..\..\Views\EntityForm\_Footer.cshtml"
                                      Write(user.UpdateUserName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 47 "..\..\Views\EntityForm\_Footer.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 48 "..\..\Views\EntityForm\_Footer.cshtml"
             if (time != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 50 "..\..\Views\EntityForm\_Footer.cshtml"
                                      Write(time.UpdateTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 51 "..\..\Views\EntityForm\_Footer.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 52 "..\..\Views\EntityForm\_Footer.cshtml"
             if (!Object.Equals(uip, null))
            {
                var ip = entity[uip.Name] + "";

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"text-primary\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2077), Tuple.Create("\"", 2088)
            
            #line 55 "..\..\Views\EntityForm\_Footer.cshtml"
, Tuple.Create(Tuple.Create("", 2085), Tuple.Create<System.Object, System.Int32>(ip
            
            #line default
            #line hidden
, 2085), false)
);

WriteLiteral(">");

            
            #line 55 "..\..\Views\EntityForm\_Footer.cshtml"
                                                  Write(ip.IPToAddress());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 56 "..\..\Views\EntityForm\_Footer.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 57 "..\..\Views\EntityForm\_Footer.cshtml"
             if (!Object.Equals(remark, null))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">");

            
            #line 60 "..\..\Views\EntityForm\_Footer.cshtml"
                                                     Write(remark.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <div");

WriteLiteral(" class=\"input-group col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 62 "..\..\Views\EntityForm\_Footer.cshtml"
                   Write(Html.ForString(remark.Name, (String)entity[remark.Name], -1));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 63 "..\..\Views\EntityForm\_Footer.cshtml"
                   Write(Html.ForDescription(remark));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

            
            #line 66 "..\..\Views\EntityForm\_Footer.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n");

            
            #line 69 "..\..\Views\EntityForm\_Footer.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
