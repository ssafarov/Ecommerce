﻿using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MrCMS.Web.Apps.Ecommerce.Services.Templating
{
    public interface INotificationTemplateProcessor
    {
        string ReplaceTokensAndMethods<T>(T tokenProvider,string Template);
        string ReplaceExtensionMethods<T>(T tokenProvider, string Template);
        string ReplaceMethods<T>(T tokenProvider, string Template);
        string ReplaceTokens<T>(T tokenProvider, string Template);
        string ReplaceTokensForString(string template, Dictionary<string, string> replacements);
        MatchCollection GetRegexMatches(string template);
    }
}