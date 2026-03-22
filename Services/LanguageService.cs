namespace Portfolio.Services;

public class LanguageService
{
    public enum Language
    {
        FR,
        EN
    }

    public Language Current { get; private set; } = Language.FR;
    public event Action? OnLanguageChanged;

    public void SetLanguage(Language lang)
    {
        if (Current == lang) return;
        Current = lang;
        OnLanguageChanged?.Invoke();
    }

    public string T(string key) => Translations.Get(key, Current);
}
