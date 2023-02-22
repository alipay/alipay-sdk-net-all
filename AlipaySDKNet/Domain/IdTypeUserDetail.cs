using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IdTypeUserDetail Data Structure.
    /// </summary>
    [Serializable]
    public class IdTypeUserDetail : AopObject
    {
        /// <summary>
        /// idType
        /// </summary>
        [XmlElement("id_type_1")]
        public string IdType1 { get; set; }

        /// <summary>
        /// idType
        /// </summary>
        [XmlElement("id_type_2")]
        public string IdType2 { get; set; }

        /// <summary>
        /// idType
        /// </summary>
        [XmlElement("id_type_3")]
        public string IdType3 { get; set; }

        /// <summary>
        /// openId列表转义
        /// </summary>
        [XmlElement("list_string_open_id")]
        public string ListStringOpenId { get; set; }

        /// <summary>
        /// 用户id列表转义
        /// </summary>
        [XmlElement("list_string_user_id")]
        public string ListStringUserId { get; set; }

        /// <summary>
        /// openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// openId列表
        /// </summary>
        [XmlArray("open_id_list")]
        [XmlArrayItem("string")]
        public List<string> OpenIdList { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户id列表
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
