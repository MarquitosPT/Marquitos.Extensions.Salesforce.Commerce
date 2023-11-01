using Marquitos.Salesforce.Commerce.Enums;

namespace Marquitos.Salesforce.Commerce.Models.Shared
{
    /// <summary>
    /// Represents a list of localized strings
    /// </summary>
    public class LocalizedStrings : List<LocalizedString>
    {
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public LocalizedStrings()
        { }

        /// <summary>
        /// Creates a new instance with a single localized string value
        /// </summary>
        /// <param name="value">The string value</param>
        /// <param name="language">The language of the string value</param>
        public LocalizedStrings(string value, Language language = Language.Default)
        {
            Add(new LocalizedString(value, language));
        }

        /// <summary>
        /// Creates a new instance with a single localized string value
        /// </summary>
        /// <param name="value">The localized string object</param>
        public LocalizedStrings(LocalizedString value)
        {
            Add(value);
        }

        /// <summary>
        /// Creates a new instance with the provided localized string values
        /// </summary>
        /// <param name="value">List of localized string objects</param>
        public LocalizedStrings(params LocalizedString[] value)
        {
            AddRange(value);
        }
    }
}
