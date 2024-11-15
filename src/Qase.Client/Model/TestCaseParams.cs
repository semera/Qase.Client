/*
 * Qase.io TestOps API v1
 *
 * Qase TestOps API v1 Specification.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@qase.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Qase.Client.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Qase.Client.Model
{
    /// <summary>
    /// TestCaseParams
    /// </summary>
    [JsonConverter(typeof(TestCaseParamsJsonConverter))]
    [DataContract(Name = "TestCase_params")]
    public partial class TestCaseParams : AbstractOpenAPISchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseParams" /> class
        /// with the <see cref="List{Object}" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of List&lt;Object&gt;.</param>
        public TestCaseParams(List<Object> actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseParams" /> class
        /// with the <see cref="Object" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Object.</param>
        public TestCaseParams(Object actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(List<Object>))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(Object))
                {
                    _actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: List<Object>, Object");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `List&lt;Object&gt;`. If the actual instance is not `List&lt;Object&gt;`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of List&lt;Object&gt;</returns>
        public List<Object> GetList()
        {
            return (List<Object>)ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Object`. If the actual instance is not `Object`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Object</returns>
        public Object GetObject()
        {
            return (Object)ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCaseParams {\n");
            sb.Append("  ActualInstance: ").Append(ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(ActualInstance, TestCaseParams.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of TestCaseParams
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of TestCaseParams</returns>
        public static TestCaseParams FromJson(string jsonString)
        {
            TestCaseParams newTestCaseParams = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newTestCaseParams;
            }

            try
            {
                newTestCaseParams = new TestCaseParams(JsonConvert.DeserializeObject<List<Object>>(jsonString, TestCaseParams.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newTestCaseParams;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into List<Object>: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newTestCaseParams = new TestCaseParams(JsonConvert.DeserializeObject<Object>(jsonString, TestCaseParams.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newTestCaseParams;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Object: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

    }

    /// <summary>
    /// Custom JSON converter for TestCaseParams
    /// </summary>
    public class TestCaseParamsJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(TestCaseParams).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return TestCaseParams.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return TestCaseParams.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
