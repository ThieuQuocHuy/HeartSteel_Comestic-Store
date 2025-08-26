using System;
using System.Drawing;
using System.IO;
using System.Globalization;
using System.Resources;

namespace Presentation.Services
{
    public static class ResourceImageLoader
    {
        public static Image? LoadByFileName(string? fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return null;
            }

            try
            {
                var nameWithoutExt = Path.GetFileNameWithoutExtension(fileName);
                if (string.IsNullOrWhiteSpace(nameWithoutExt))
                {
                    System.Diagnostics.Trace.WriteLine($"[IMG] Empty name from '{fileName}'");
                    return null;
                }

                // Resources key is usually the file name without extension.
                var key = nameWithoutExt;

                var obj = Presentation.Properties.Resources.ResourceManager.GetObject(key);
                if (obj is Image img)
                {
                    System.Diagnostics.Trace.WriteLine($"[IMG] Loaded from Resources by exact key '{key}'");
                    return img;
                }

                // Try a normalized variant (replace spaces and dashes with underscore)
                var normalized = key.Replace(" ", "_").Replace("-", "_");
                if (!string.Equals(normalized, key, StringComparison.Ordinal))
                {
                    obj = Presentation.Properties.Resources.ResourceManager.GetObject(normalized);
                    if (obj is Image img2)
                    {
                        System.Diagnostics.Trace.WriteLine($"[IMG] Loaded from Resources by normalized key '{normalized}'");
                        return img2;
                    }
                }

                // Case-insensitive search in ResourceSet
                var rs = Presentation.Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
                if (rs != null)
                {
                    foreach (System.Collections.DictionaryEntry entry in rs)
                    {
                        var k = entry.Key as string;
                        if (!string.IsNullOrEmpty(k) && string.Equals(k, key, StringComparison.OrdinalIgnoreCase))
                        {
                            if (entry.Value is Image img3)
                            {
                                System.Diagnostics.Trace.WriteLine($"[IMG] Loaded from Resources by case-insensitive key '{k}' for '{key}'");
                                return img3;
                            }
                        }
                    }
                }

                // Fall back: try to load from local Resource folder by file name
                var baseDir = AppDomain.CurrentDomain.BaseDirectory;
                var candidate = Path.Combine(baseDir, "Resource", fileName);
                if (File.Exists(candidate))
                {
                    using var fs = new FileStream(candidate, FileMode.Open, FileAccess.Read, FileShare.Read);
                    System.Diagnostics.Trace.WriteLine($"[IMG] Loaded from file '{candidate}'");
                    return Image.FromStream(fs);
                }

                // Another fallback: try directly next to executable
                var candidate2 = Path.Combine(baseDir, fileName);
                if (File.Exists(candidate2))
                {
                    using var fs2 = new FileStream(candidate2, FileMode.Open, FileAccess.Read, FileShare.Read);
                    System.Diagnostics.Trace.WriteLine($"[IMG] Loaded from file '{candidate2}'");
                    return Image.FromStream(fs2);
                }

                // During development, try going up parent directories to find the project Resource folder
                var parent = Directory.GetParent(baseDir);
                for (int i = 0; i < 5 && parent != null; i++)
                {
                    var devCandidate = Path.Combine(parent.FullName, "Resource", fileName);
                    if (File.Exists(devCandidate))
                    {
                        using var fs3 = new FileStream(devCandidate, FileMode.Open, FileAccess.Read, FileShare.Read);
                        System.Diagnostics.Trace.WriteLine($"[IMG] Loaded from dev file '{devCandidate}'");
                        return Image.FromStream(fs3);
                    }
                    parent = parent.Parent;
                }

                System.Diagnostics.Trace.WriteLine($"[IMG] Not found: key='{key}', file='{candidate}' or '{candidate2}'");
            }
            catch
            {
                // ignore and fall through to null
            }

            return null;
        }
    }
}


