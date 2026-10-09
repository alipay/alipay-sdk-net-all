using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceOldapitreeRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceOldapitreeRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 引用复杂类型
        /// </summary>
        [XmlElement("complex_ref")]
        public RainyComplexTypesTheFourth ComplexRef { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlArray("idjson_open_ids")]
        [XmlArrayItem("string")]
        public List<string> IdjsonOpenIds { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("idtype_open_id")]
        public string IdtypeOpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。-- idType
        /// </summary>
        [XmlElement("idtype_user_id")]
        public string IdtypeUserId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id_idtype")]
        public string UserIdIdtype { get; set; }
    }
}
