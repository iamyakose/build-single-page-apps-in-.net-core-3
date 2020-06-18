#pragma checksum "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "016544f59ad32a23565fe7f31e6b5294a097e754"
// <auto-generated/>
#pragma warning disable 1591
namespace frontendlib.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/_Imports.razor"
using frontendlib.Models;

#line default
#line hidden
#line 3 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 4 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
    public partial class ItemList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 3 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
                                          OnAddClick

#line default
#line hidden
            ));
            __builder.AddContent(3, "Add ");
            __builder.AddContent(4, 
#line 3 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
                                                           Model.ItemName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table mt-3");
            __builder.AddMarkupContent(8, "\n  ");
            __builder.OpenElement(9, "thead");
            __builder.AddMarkupContent(10, "\n    ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\n      <th></th>\n");
#line 8 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
       foreach (var header in Model.Headers)
      {

#line default
#line hidden
            __builder.AddContent(13, "        ");
            __builder.OpenElement(14, "th");
            __builder.AddContent(15, 
#line 10 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
             header

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n");
#line 11 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
      }

#line default
#line hidden
            __builder.AddMarkupContent(17, "      <th></th>\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n  ");
            __builder.OpenElement(20, "tbody");
            __builder.AddMarkupContent(21, "\n");
#line 16 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
     foreach (var item in Model.Items)
    {

#line default
#line hidden
            __builder.AddContent(22, "    ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\n      ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-warning");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 19 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
                                                    e => OnEditClick.InvokeAsync(item)

#line default
#line hidden
            ));
            __builder.AddContent(29, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
#line 20 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
       foreach(var property in item.GetType().GetProperties())
      {

#line default
#line hidden
            __builder.AddContent(31, "        ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#line 22 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
             property.GetValue(item)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
#line 23 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
      }

#line default
#line hidden
            __builder.AddContent(35, "      ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-danger");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 24 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
                                                   e => ShowConfirm(item)

#line default
#line hidden
            ));
            __builder.AddContent(40, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "        \n");
#line 26 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
    }

#line default
#line hidden
            __builder.AddContent(43, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n\n");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal");
            __builder.AddAttribute(48, "id", "deletemodal");
            __builder.AddMarkupContent(49, "\n  ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "modal-dialog");
            __builder.AddMarkupContent(52, "\n    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "modal-content");
            __builder.AddMarkupContent(55, "\n      ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "modal-header");
            __builder.AddMarkupContent(58, "\n        ");
            __builder.OpenElement(59, "h4");
            __builder.AddAttribute(60, "class", "modal-title");
            __builder.AddContent(61, "Delete ");
            __builder.AddContent(62, 
#line 34 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
                                        Model.ItemName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n        ");
            __builder.AddMarkupContent(64, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n      ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "modal-body");
            __builder.AddMarkupContent(68, "\n        Do you want to delete the ");
            __builder.AddContent(69, 
#line 38 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
                                   Model.ItemName?.ToLower()

#line default
#line hidden
            );
            __builder.AddMarkupContent(70, " ?\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\n      ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "modal-footer");
            __builder.AddMarkupContent(74, "\n        ");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "type", "button");
            __builder.AddAttribute(77, "class", "btn btn-danger");
            __builder.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 41 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
                                                               OnYesClick

#line default
#line hidden
            ));
            __builder.AddContent(79, "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\n        ");
            __builder.AddMarkupContent(81, "<button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">No</button>\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 48 "/Users/micheleaponte/book/blazor/update/article-manager/frontendlib/Components/ItemList.razor"
       

    [Parameter]
    public ItemListModel Model { get; set; }

    [Parameter]
    public EventCallback OnAddClick { get; set; }

    [Parameter]
    public EventCallback<object> OnEditClick { get; set; }

    [Parameter]
    public EventCallback<object> OnDeleteClick { get; set; }

    private object itemToDelete;

    private async Task ShowConfirm(object item)
    {
      this.itemToDelete = item;
      await JSRuntime.InvokeVoidAsync("showConfirmDelete", "deletemodal");
    }

    private async Task OnYesClick()
    {
      await OnDeleteClick.InvokeAsync(this.itemToDelete);
      await JSRuntime.InvokeVoidAsync("hideConfirmDelete", "deletemodal");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
