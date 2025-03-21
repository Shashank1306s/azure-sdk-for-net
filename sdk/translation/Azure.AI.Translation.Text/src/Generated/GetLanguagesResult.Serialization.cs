// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    public partial class GetLanguagesResult
    {
        internal static GetLanguagesResult DeserializeGetLanguagesResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyDictionary<string, TranslationLanguage>> translation = default;
            Optional<IReadOnlyDictionary<string, TransliterationLanguage>> transliteration = default;
            Optional<IReadOnlyDictionary<string, SourceDictionaryLanguage>> dictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("translation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, TranslationLanguage> dictionary0 = new Dictionary<string, TranslationLanguage>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary0.Add(property0.Name, TranslationLanguage.DeserializeTranslationLanguage(property0.Value));
                    }
                    translation = dictionary0;
                    continue;
                }
                if (property.NameEquals("transliteration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, TransliterationLanguage> dictionary0 = new Dictionary<string, TransliterationLanguage>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary0.Add(property0.Name, TransliterationLanguage.DeserializeTransliterationLanguage(property0.Value));
                    }
                    transliteration = dictionary0;
                    continue;
                }
                if (property.NameEquals("dictionary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, SourceDictionaryLanguage> dictionary0 = new Dictionary<string, SourceDictionaryLanguage>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary0.Add(property0.Name, SourceDictionaryLanguage.DeserializeSourceDictionaryLanguage(property0.Value));
                    }
                    dictionary = dictionary0;
                    continue;
                }
            }
            return new GetLanguagesResult(Optional.ToDictionary(translation), Optional.ToDictionary(transliteration), Optional.ToDictionary(dictionary));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GetLanguagesResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGetLanguagesResult(document.RootElement);
        }
    }
}
