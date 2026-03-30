using System.Collections;
using System.Globalization;
using System.Text.Json;
using Microsoft.Extensions.Localization;

namespace RetakesAllocatorCore;

public sealed class JsonStringLocalizer : IStringLocalizer
{
    private readonly Dictionary<string, string> _strings;

    public JsonStringLocalizer(string languageDirectory, string fileName = "en.json")
    {
        var path = Path.Combine(languageDirectory, fileName);
        if (!File.Exists(path))
        {
            _strings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            return;
        }

        var json = File.ReadAllText(path);
        _strings = JsonSerializer.Deserialize<Dictionary<string, string>>(json)
            ?? new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
    }

    public LocalizedString this[string name]
    {
        get
        {
            var found = _strings.TryGetValue(name, out var value);
            return new LocalizedString(name, found ? value! : name, !found);
        }
    }

    public LocalizedString this[string name, params object[] arguments]
    {
        get
        {
            var baseString = this[name];
            if (baseString.ResourceNotFound)
            {
                return baseString;
            }

            var formatted = string.Format(CultureInfo.InvariantCulture, baseString.Value, arguments);
            return new LocalizedString(name, formatted, false);
        }
    }

    public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
    {
        return _strings.Select(kv => new LocalizedString(kv.Key, kv.Value, false));
    }

    public IStringLocalizer WithCulture(CultureInfo culture)
    {
        return this;
    }
}
