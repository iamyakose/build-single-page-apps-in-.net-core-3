#pragma checksum "/Users/micheleaponte/Desktop/Chapter3/article-manager-wasm/step5/frontend/Components/ArticleCategoriesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87ff7c336615475a9b8da926fbca6749a135794e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace frontend.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/micheleaponte/Desktop/Chapter3/article-manager-wasm/step5/frontend/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/micheleaponte/Desktop/Chapter3/article-manager-wasm/step5/frontend/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/micheleaponte/Desktop/Chapter3/article-manager-wasm/step5/frontend/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/micheleaponte/Desktop/Chapter3/article-manager-wasm/step5/frontend/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/micheleaponte/Desktop/Chapter3/article-manager-wasm/step5/frontend/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/micheleaponte/Desktop/Chapter3/article-manager-wasm/step5/frontend/_Imports.razor"
using frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/micheleaponte/Desktop/Chapter3/article-manager-wasm/step5/frontend/_Imports.razor"
using frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/micheleaponte/Desktop/Chapter3/article-manager-wasm/step5/frontend/_Imports.razor"
using shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/micheleaponte/Desktop/Chapter3/article-manager-wasm/step5/frontend/_Imports.razor"
using frontend.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/micheleaponte/Desktop/Chapter3/article-manager-wasm/step5/frontend/_Imports.razor"
using frontend.Components;

#line default
#line hidden
#nullable disable
    public partial class ArticleCategoriesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "/Users/micheleaponte/Desktop/Chapter3/article-manager-wasm/step5/frontend/Components/ArticleCategoriesList.razor"
       

    [Parameter]
    public ArticleCategoryListItem[] ArticleCategoryListItems { get; set; }

    [Parameter]
    public EventCallback OnAddClick { get; set; }

    [Parameter]
    public EventCallback<ArticleCategoryListItem> OnEditClick { get; set; }

    [Parameter]
    public EventCallback<ArticleCategoryListItem> OnDeleteClick { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
