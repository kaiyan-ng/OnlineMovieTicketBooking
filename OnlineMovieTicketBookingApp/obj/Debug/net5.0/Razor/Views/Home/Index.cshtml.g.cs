#pragma checksum "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "036c72c7ac9c9080b870ec302fc953cfc5d3e73b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"036c72c7ac9c9080b870ec302fc953cfc5d3e73b", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    body{
        background-color:black;
        color:white;
    }
    .jumbotron {
        background-image: url(""../MiscImages/MovieReelBanner.jpg"");
        background-size: cover;
        height:600px;
    }
    .display-movies{
        height:500px;
        overflow: hidden;
    }
    .card {
");
            WriteLiteral(@"        /*left: 30px;*/
        top: 20px;
        text-align: center;
        color: white;
        background-color: black;
        font-family: Arial, Helvetica, sans-serif;
        float: left;
        margin: 5px;
    }

    .card-img-top {
        width: 60%;
        height: auto;
        object-fit: cover;
    }

    .card-title {
        font-size: 13px;
    }

    .card-text {
        font-size: 11px;
    }
    .now-showing{
        position: relative;
        left:50px;
        font-size:30px;
    }
</style>

<div class=""jumbotron jumbotron-fluid"">
    <div class=""container"">
        <br /><br /><br />
        <h1 class=""display-4"">Welcome to Scene-nigma!</h1>
        <p class=""lead"">Life is an enigma. Navigate through yours with every scene.</p>
        <p>Begin your journey with Scene-nigma...</p>
");
            WriteLiteral("        <br /><br />\r\n    </div>\r\n</div>\r\n\r\n<section class=\"display-movies\">\r\n    <h3 class=\"now-showing\">Movies</h3>\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 70 "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("_NowShowing"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
