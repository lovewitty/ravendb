namespace Raven.Studio.Features.JsonEditor
{
    using ActiproSoftware.Text;
    using ActiproSoftware.Text.Tagging;
    using ActiproSoftware.Text.Tagging.Implementation;
    using System;

    /// <summary>
    /// Represents a provider of <see cref="JsonTokenTagger"/> objects for documents that use the <c>JsonTokenTagger</c> language.
    /// </summary>
    /// <remarks>
    /// This type was generated by the Actipro Language Designer tool v12.1.561.0 (http://www.actiprosoftware.com).
    /// </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("LanguageDesigner", "12.1.561.0")]
    public partial class JsonTokenTaggerProvider : TaggerProviderBase<JsonTokenTagger>, ICodeDocumentTaggerProvider
    {

        private IJsonClassificationTypeProvider classificationTypeProviderValue;

        /// <summary>
        /// Initializes a new instance of the <c>JsonTokenTaggerProvider</c> class.
        /// </summary>
        /// <param name="classificationTypeProvider">A <see cref="IJsonClassificationTypeProvider"/> that provides classification types.</param>
        public JsonTokenTaggerProvider(IJsonClassificationTypeProvider classificationTypeProvider)
        {
            if ((classificationTypeProvider == null))
                throw new ArgumentNullException("classificationTypeProvider");

            // Initialize
            classificationTypeProviderValue = classificationTypeProvider;
        }

        /// <summary>
        /// Returns a tagger for the specified <see cref="ICodeDocument"/>.
        /// </summary>
        /// <typeparam name="T">The type of <see cref="ITag"/> created by the tagger.</typeparam>
        /// <param name="document">The <see cref="ICodeDocument"/> that requires a tagger.</param>
        /// <returns>A tagger for the specified <see cref="ICodeDocument"/>.</returns>
        public ITagger<T> GetTagger<T>(ICodeDocument document) where T : ITag
        {
            if (typeof (ITagger<T>).IsAssignableFrom(typeof (JsonTokenTagger)))
            {
                var factory = new TaggerFactory(this, document);
                return ((ITagger<T>) (document.Properties.GetOrCreateSingleton(typeof (ITagger<ITokenTag>),
                                                               new ActiproSoftware.Text.Utility.PropertyDictionary.
                                                                   Creator<JsonTokenTagger>(factory.CreateTagger))));
            }
            
            return null;
        }

        /// <summary>
        /// Implements a factory that can creates <see cref="JsonTokenTagger"/> objects for a document.
        /// </summary>
        public class TaggerFactory
        {

            private ICodeDocument documentValue;

            private JsonTokenTaggerProvider providerValue;

            /// <summary>
            /// Initializes a new instance of the <c>TaggerFactory</c> class.
            /// </summary>
            /// <param name="provider">The owner <see cref="JsonTokenTaggerProvider"/>.</param>
            /// <param name="document">The <see cref="ICodeDocument"/> that requires an <see cref="JsonTokenTagger"/>.</param>
            internal TaggerFactory(JsonTokenTaggerProvider provider, ICodeDocument document)
            {
                // Initialize
                providerValue = provider;
                documentValue = document;
            }

            /// <summary>
            /// Creates an <see cref="JsonTokenTagger"/> for the <see cref="ICodeDocument"/>.
            /// </summary>
            /// <returns>An <see cref="JsonTokenTagger"/> for the <see cref="ICodeDocument"/>.</returns>
            public JsonTokenTagger CreateTagger()
            {
                return new JsonTokenTagger(documentValue, providerValue.classificationTypeProviderValue);
            }
        }
    }
}