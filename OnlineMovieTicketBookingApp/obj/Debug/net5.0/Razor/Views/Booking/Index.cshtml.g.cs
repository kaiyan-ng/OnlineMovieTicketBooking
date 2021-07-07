#pragma checksum "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Booking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03ae2e156c09c4202011817e26b9cc1dc350c82e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Index), @"mvc.1.0.view", @"/Views/Booking/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ae2e156c09c4202011817e26b9cc1dc350c82e", @"/Views/Booking/Index.cshtml")]
    public class Views_Booking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMovieTicketBookingApp.Models.BookingViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Booking\Index.cshtml"
  
    ViewData["Title"] = "Booking Step 1";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n");
            WriteLiteral(@"
<style>
        body {
            background-color: black;
            color:white;
            overflow:hidden;
        }

        
    .step_num1 {
        color:black;
        padding: 20px;
        border: 1px solid #ccc;
        background: white;
        border-radius: 50%;
        width: 40px;
        height: 40px;
        display: flex;
        align-items: center;
        justify-content: center;
    }
    .step_num2 {
        color: black;
        padding: 20px;
        border: 1px solid grey;
        background: grey;
        border-radius: 50%;
        width: 40px;
        height: 40px;
        display: flex;
        align-items: center;
        justify-content: center;
    }
    .inactive-page{
        color:grey;
    }
    .section_bg {
       /* background: #fff;*/
        padding-top: 50px;
    }
    .steps, .box-center {
        display: flex;
        justify-content: center !important;
        align-items: center;
    }
    .row-padding {
     ");
            WriteLiteral(@"   padding-top:10px;
    }
    .heading{/*
        position: relative;
        top:30px;*/
        text-align:center;

    }
    .selection{
        position: relative;
        top:30px;
        left:120px;
    }
    .buttons{
        position:relative;
        top:30px;
        left:225px;
    }
    .form-control{
        width:180px;
        height:30px;
    }
</style>

<script>

</script>


<div class=""container"">
    <div class=""section_bg"">

        <div class=""row justify-content-center"">
            <div class=""col-lg-3 text-center"">
                <div class=""steps"">
                    <div class=""step_num1""><b>1</b></div>
                </div>
                <p><b>Select Tickets</b></p>
            </div>
            <div class=""col-lg-6""><hr /></div>
            <div class=""col-lg-3 text-center"">
                <div class=""steps"">
                    <div class=""step_num2"">2</div>
                </div>
                <p class=""inactive-page"">Confirm");
            WriteLiteral("ation</p>\r\n            </div>\r\n        </div>\r\n\r\n        <h4 class=\"heading\">Select Tickets</h4>\r\n\r\n");
#nullable restore
#line 106 "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Booking\Index.cshtml"
         using (Html.BeginForm("Index", "Booking", new { movieId = @Model.Movie.Id }, FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""selection"">
                <div class=""row justify-content-center"">
                    <div class=""col box-center"">
                        <div style=""width: 700px"">
                            <div class=""row row-padding"">
                                <div class=""col-lg-3"">
                                    Movie:
                                </div>
                                <div class=""col"">
                                    ");
#nullable restore
#line 117 "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Booking\Index.cshtml"
                               Write(Html.Hidden("Customer_Id", @TempData.Peek("CustomerId")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 118 "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Booking\Index.cshtml"
                               Write(Html.Hidden("Movie_Id", @Model.Movie.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 119 "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Booking\Index.cshtml"
                               Write(Html.Hidden("Total_Price", 0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 120 "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Booking\Index.cshtml"
                               Write(Model.Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""row row-padding"">
                                <div class=""col-lg-3"">
                                    Hall No.:
                                </div>
                                <div class=""col"">
                                    1
                                </div>
                            </div>
                            <div class=""row row-padding"">
                                <div class=""col-lg-3"">
                                    Ticket Price:
                                </div>
                                <div class=""col"">
                                    $<label id=""lblPrice"" style=""font-weight:bold"">");
#nullable restore
#line 136 "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Booking\Index.cshtml"
                                                                              Write(Model.Movie.Ticket_Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                </div>
                            </div>
                            <div class=""row row-padding"">
                                <div class=""col-lg-3"">
                                    Show Date & Time:
                                </div>
                                <div class=""col"">
                                    ");
#nullable restore
#line 144 "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Booking\Index.cshtml"
                               Write(Html.DropDownListFor(model => model.Show_Id, new SelectList(Model.Shows, "Id", "Date_And_Time")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""row row-padding"">
                                <div class=""col-lg-3"">
                                    Total tickets
                                </div>
                                <div class=""col"">
                                    ");
#nullable restore
#line 152 "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Booking\Index.cshtml"
                               Write(Html.EditorFor(model => model.Total_Tickets, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 153 "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Booking\Index.cshtml"
                               Write(Html.ValidationMessageFor(m => m.Total_Tickets, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""row row-padding"">
                                <div class=""col-lg-3"">
                                    Total price
                                </div>
                                <div class=""col"">
                                    <label id=""lblTotalPrice"" style=""font-weight:bold"" />
                                </div>
                            </div>
                        </div>
                    </div>


                </div>
            </div>
");
            WriteLiteral("            <div class=\"row buttons\" style=\"padding:20px;\">\r\n\r\n                <div class=\"col-lg-6 justify-content-start\">\r\n                    ");
#nullable restore
#line 175 "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Booking\Index.cshtml"
               Write(Html.ActionLink("Cancel", "Index", "Home", null, new { @class = "btn btn-outline-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                \r\n                <div class=\"col-lg-6 justify-content-end\">\r\n                    <button class=\"btn btn-warning\">Next</button>\r\n                </div>\r\n                <br /><br />\r\n            </div>\r\n");
#nullable restore
#line 183 "C:\Users\kaiya\Source\Repos\TicketBooking\OnlineMovieTicketBookingApp\Views\Booking\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>


</div>

<script>
    $(document).ready(function () {
        $(""#Total_Tickets"").on(""change"", function () {
            var tickets = $(this).val();
            var price = $(""#lblPrice"").text();
            var total = tickets * price;
            $(""#Total_Price"").val(total);
            $(""#lblTotalPrice"").text(""$"" + total);
        });
    })
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMovieTicketBookingApp.Models.BookingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591