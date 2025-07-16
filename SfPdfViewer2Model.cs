using DevExpress.ExpressApp.Blazor.Components.Models;
using JMTech.ExpressApp.Blazor.Editors.Renderers;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.SfPdfViewer;

namespace JMTech.ExpressApp.Blazor.Editors.Models;

public class SfPdfViewer2Model : ComponentModelBase
{
    public string? DownloadFileName
    {
        get => GetPropertyValue<string?>();
        set => SetPropertyValue(value);
    }

    public bool EnableFormFields
    {
        get => GetPropertyValue<bool>(true);
        set => SetPropertyValue(value);
    }

    public string Height
    {
        get => GetPropertyValue<string>("100%");
        set => SetPropertyValue(value);
    }

    public string Width
    {
        get => GetPropertyValue<string>("100%");
        set => SetPropertyValue(value);
    }

    public int ZoomValue
    {
        get => GetPropertyValue<int>();
        set => SetPropertyValue(value);
    }

    public bool EnableErrorDialog
    {
        get => GetPropertyValue<bool>(true);
        set => SetPropertyValue(value);
    }

    public string? DocumentPath
    {
        get => GetPropertyValue<string?>();
        set => SetPropertyValue(value);
    }

    public EventCallback<Dictionary<string, string>> FormFieldUpdated
    {
        get => GetPropertyValue<EventCallback<Dictionary<string, string>>>();
        set => SetPropertyValue(value);
    }

    public EventCallback ExportingFormFieldStarted
    {
        get => GetPropertyValue<EventCallback>();
        set => SetPropertyValue(value);
    }

    public EventCallback ExportingFormFieldEnded
    {
        get => GetPropertyValue<EventCallback>();
        set => SetPropertyValue(value);
    }

    public bool EnableContextMenu
    {
        get => GetPropertyValue<bool>(true);
        set => SetPropertyValue(value);
    }

    public List<ToolbarItem> ToolbarItems
    {
        get => GetPropertyValue<List<ToolbarItem>>(
            [
                ToolbarItem.OpenOption,
                ToolbarItem.PageNavigationTool,
                ToolbarItem.MagnificationTool,
                ToolbarItem.SelectionTool,
                ToolbarItem.PanTool,
                ToolbarItem.UndoRedoTool,
                ToolbarItem.CommentTool,
                ToolbarItem.SubmitForm,
                ToolbarItem.SearchOption,
                ToolbarItem.AnnotationEditTool,
                ToolbarItem.PrintOption,
                ToolbarItem.DownloadOption
            ]);
        set => SetPropertyValue(value);
    }

    public Dictionary<string, string> FormFields
    {
        get => GetPropertyValue<Dictionary<string, string>>([]);
        set => SetPropertyValue(value);
    }

    public override Type ComponentType => typeof(SfPdfViewer2Renderer);
}