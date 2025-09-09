using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyComplexTypesTheFourth Data Structure.
    /// </summary>
    [Serializable]
    public class RainyComplexTypesTheFourth : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("idtye_open_id")]
        public string IdtyeOpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("idtype_user_id")]
        public string IdtypeUserId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlArray("json_open_id_json")]
        [XmlArrayItem("string")]
        public List<string> JsonOpenIdJson { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlArray("json_user_id")]
        [XmlArrayItem("string")]
        public List<string> JsonUserId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// openId-idType映射的idType字段
        /// </summary>
        [XmlElement("tc_case")]
        public string TcCase { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
