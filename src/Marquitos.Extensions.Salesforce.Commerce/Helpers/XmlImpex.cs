using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Helpers
{
    /// <summary>
    /// Xml import/export helper
    /// </summary>
    public static class XmlImpex
    {
        /// <summary>
        /// Serialize an object to Utf8Xml string
        /// </summary>
        /// <typeparam name="T">Type of value</typeparam>
        /// <param name="value">Value to be converted</param>
        /// <returns>An Utf8Xml string that represents the object</returns>
        public static string ToUtf8Xml<T>(T value)
        {
            var serializer = new XmlSerializer(typeof(T));

            using var stream = new MemoryStream();
            using var writer = new XmlTextWriter(stream, Encoding.UTF8);

            writer.Formatting = Formatting.Indented;

            serializer.Serialize(writer, value);
            return Encoding.UTF8.GetString(stream.ToArray());
        }

        /// <summary>
        /// Serialize an object to Xml string
        /// </summary>
        /// <typeparam name="T">Type of value</typeparam>
        /// <param name="value">Value to be converted</param>
        /// <returns>A Xml string that represents the object</returns>
        public static string ToXml<T>(T value)
        {
            var serializer = new XmlSerializer(typeof(T));

            using var writer = new StringWriter();

            serializer.Serialize(writer, value);
            return writer.ToString();
        }

        /// <summary>
        /// Read from a stream
        /// </summary>
        /// <typeparam name="T">Result type</typeparam>
        /// <param name="stream">The source stream</param>
        /// <returns>The deserialized object</returns>
        /// <exception cref="Exception"></exception>
        public static T ReadFrom<T>(Stream stream)
        {
            var serializer = new XmlSerializer(typeof(T));

            stream.Position = 0;
            var result = serializer.Deserialize(stream) ?? throw new Exception("Can't deserialize from the provided source.");

            return (T)result;
        }

        /// <summary>
        /// Read from a TextReader
        /// </summary>
        /// <typeparam name="T">Result type</typeparam>
        /// <param name="textReader">The source TextReader</param>
        /// <returns>The deserialized object</returns>
        /// <exception cref="Exception"></exception>
        public static T ReadFrom<T>(TextReader textReader)
        {
            var serializer = new XmlSerializer(typeof(T));

            var result = serializer.Deserialize(textReader) ?? throw new Exception("Can't deserialize from the provided source.");

            return (T)result;
        }

        /// <summary>
        /// Read from a xml string
        /// </summary>
        /// <typeparam name="T">Result type</typeparam>
        /// <param name="xml">The source TextReader</param>
        /// <returns>The deserialized object</returns>
        /// <exception cref="Exception"></exception>
        public static T ReadFrom<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));

            using var textReader = new StringReader(xml);

            var result = serializer.Deserialize(textReader) ?? throw new Exception("Can't deserialize from the provided source.");

            return (T)result;
        }

        /// <summary>
        /// Serialize an object to a destination Stream
        /// </summary>
        /// <typeparam name="T">Type of object to be serialized</typeparam>
        /// <param name="source">The object to be serialized</param>
        /// <param name="destination">The destination Stream</param>
        public static void WriteTo<T>(T source, Stream destination)
        {
            var serializer = new XmlSerializer(typeof(T));

            serializer.Serialize(destination, source);
        }

        /// <summary>
        /// Serialize an object to a destination TextWriter
        /// </summary>
        /// <typeparam name="T">Type of object to be serialized</typeparam>
        /// <param name="source">The object to be serialized</param>
        /// <param name="destination">The destination TextWriter</param>
        public static void WriteTo<T>(T source, TextWriter destination)
        {
            var serializer = new XmlSerializer(typeof(T));

            serializer.Serialize(destination, source);
        }
    }
}
