/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-19
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AlipaySDKNet.OpenAPI.Client.OpenAPIDateConverter;

namespace AlipaySDKNet.OpenAPI.Model
{
    /// <summary>
    /// AntMerchantExpandItemOpenDeleteDefaultResponse
    /// </summary>
    [JsonConverter(typeof(AntMerchantExpandItemOpenDeleteDefaultResponseJsonConverter))]
    [DataContract(Name = "ant_merchant_expand_item_open_delete_default_response")]
    public partial class AntMerchantExpandItemOpenDeleteDefaultResponse : AbstractOpenAPISchema, IEquatable<AntMerchantExpandItemOpenDeleteDefaultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandItemOpenDeleteDefaultResponse" /> class
        /// with the <see cref="AntMerchantExpandItemOpenDeleteErrorResponseModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AntMerchantExpandItemOpenDeleteErrorResponseModel.</param>
        public AntMerchantExpandItemOpenDeleteDefaultResponse(AntMerchantExpandItemOpenDeleteErrorResponseModel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandItemOpenDeleteDefaultResponse" /> class
        /// with the <see cref="CommonErrorType" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CommonErrorType.</param>
        public AntMerchantExpandItemOpenDeleteDefaultResponse(CommonErrorType actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
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
                if (value.GetType() == typeof(AntMerchantExpandItemOpenDeleteErrorResponseModel))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CommonErrorType))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AntMerchantExpandItemOpenDeleteErrorResponseModel, CommonErrorType");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AntMerchantExpandItemOpenDeleteErrorResponseModel`. If the actual instance is not `AntMerchantExpandItemOpenDeleteErrorResponseModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AntMerchantExpandItemOpenDeleteErrorResponseModel</returns>
        public AntMerchantExpandItemOpenDeleteErrorResponseModel GetAntMerchantExpandItemOpenDeleteErrorResponseModel()
        {
            return (AntMerchantExpandItemOpenDeleteErrorResponseModel)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CommonErrorType`. If the actual instance is not `CommonErrorType`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CommonErrorType</returns>
        public CommonErrorType GetCommonErrorType()
        {
            return (CommonErrorType)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AntMerchantExpandItemOpenDeleteDefaultResponse {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, AntMerchantExpandItemOpenDeleteDefaultResponse.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AntMerchantExpandItemOpenDeleteDefaultResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AntMerchantExpandItemOpenDeleteDefaultResponse</returns>
        public static AntMerchantExpandItemOpenDeleteDefaultResponse FromJson(string jsonString)
        {
            AntMerchantExpandItemOpenDeleteDefaultResponse newAntMerchantExpandItemOpenDeleteDefaultResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAntMerchantExpandItemOpenDeleteDefaultResponse;
            }

            try
            {
                newAntMerchantExpandItemOpenDeleteDefaultResponse = new AntMerchantExpandItemOpenDeleteDefaultResponse(JsonConvert.DeserializeObject<AntMerchantExpandItemOpenDeleteErrorResponseModel>(jsonString, AntMerchantExpandItemOpenDeleteDefaultResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAntMerchantExpandItemOpenDeleteDefaultResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AntMerchantExpandItemOpenDeleteErrorResponseModel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newAntMerchantExpandItemOpenDeleteDefaultResponse = new AntMerchantExpandItemOpenDeleteDefaultResponse(JsonConvert.DeserializeObject<CommonErrorType>(jsonString, AntMerchantExpandItemOpenDeleteDefaultResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAntMerchantExpandItemOpenDeleteDefaultResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CommonErrorType: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AntMerchantExpandItemOpenDeleteDefaultResponse);
        }

        /// <summary>
        /// Returns true if AntMerchantExpandItemOpenDeleteDefaultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AntMerchantExpandItemOpenDeleteDefaultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntMerchantExpandItemOpenDeleteDefaultResponse input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for AntMerchantExpandItemOpenDeleteDefaultResponse
    /// </summary>
    public class AntMerchantExpandItemOpenDeleteDefaultResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AntMerchantExpandItemOpenDeleteDefaultResponse).GetMethod("ToJson").Invoke(value, null)));
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
            if(reader.TokenType != JsonToken.Null)
            {
                return AntMerchantExpandItemOpenDeleteDefaultResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
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
