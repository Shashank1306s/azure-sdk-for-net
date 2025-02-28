// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    internal partial class SearchResult
    {
        internal static SearchResult DeserializeSearchResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double searchScore = default;
            Optional<double?> searchRerankerScore = default;
            Optional<IReadOnlyDictionary<string, IList<string>>> searchHighlights = default;
            Optional<IReadOnlyList<CaptionResult>> searchCaptions = default;
            Optional<IReadOnlyList<DocumentDebugInfo>> searchDocumentDebugInfo = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@search.score"u8))
                {
                    searchScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("@search.rerankerScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchRerankerScore = null;
                        continue;
                    }
                    searchRerankerScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("@search.highlights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dictionary.Add(property0.Name, array);
                        }
                    }
                    searchHighlights = dictionary;
                    continue;
                }
                if (property.NameEquals("@search.captions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchCaptions = null;
                        continue;
                    }
                    List<CaptionResult> array = new List<CaptionResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CaptionResult.DeserializeCaptionResult(item));
                    }
                    searchCaptions = array;
                    continue;
                }
                if (property.NameEquals("@search.documentDebugInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchDocumentDebugInfo = null;
                        continue;
                    }
                    List<DocumentDebugInfo> array = new List<DocumentDebugInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DocumentDebugInfo.DeserializeDocumentDebugInfo(item));
                    }
                    searchDocumentDebugInfo = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SearchResult(searchScore, Optional.ToNullable(searchRerankerScore), Optional.ToDictionary(searchHighlights), Optional.ToList(searchCaptions), Optional.ToList(searchDocumentDebugInfo), additionalProperties);
        }
    }
}
