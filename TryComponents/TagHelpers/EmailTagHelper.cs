using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TryComponents.TagHelpers;

public enum EmailType 
{
    ShowEmail,
    ShowMailTo
}

[HtmlTargetElement("email", TagStructure = TagStructure.WithoutEndTag)]
public class EmailTagHelper : TagHelper
{
    private const string EmailDomain = "oxemoron.com";

    [HtmlAttributeName("recipient")]
    public string MailTo {get;set;}

    public EmailType EmailType {get;set;}

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "a";
        output.TagMode = TagMode.StartTagAndEndTag;

        var address = MailTo + "@" + EmailDomain;
        output.Attributes.SetAttribute("href", "mailto:" + address);

        if (EmailType == EmailType.ShowEmail) 
        {
            output.Content.SetContent(address);
        } 
        else 
        {
            output.Content.SetContent(MailTo);
        }
        
    }

}
