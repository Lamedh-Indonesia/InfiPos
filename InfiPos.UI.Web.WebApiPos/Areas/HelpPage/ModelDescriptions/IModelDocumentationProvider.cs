using System;
using System.Reflection;

namespace InfiPos.UI.Web.WebApiPos.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}