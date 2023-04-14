using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IdTypeTestComplexParam Data Structure.
    /// </summary>
    [Serializable]
    public class IdTypeTestComplexParam : AopObject
    {
        /// <summary>
        /// idType
        /// </summary>
        [XmlElement("a_id_type")]
        public string AIdType { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        [XmlElement("a_open_id")]
        public string AOpenId { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("a_user_id")]
        public string AUserId { get; set; }

        /// <summary>
        /// USER_ID
        /// </summary>
        [XmlElement("b_id_type_list")]
        public string BIdTypeList { get; set; }

        /// <summary>
        /// 用户openId列表
        /// </summary>
        [XmlArray("b_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> BOpenIdList { get; set; }

        /// <summary>
        /// 用户uid列表
        /// </summary>
        [XmlArray("b_user_id_list")]
        [XmlArrayItem("string")]
        public List<string> BUserIdList { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("expect_a_id_type")]
        public string ExpectAIdType { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("expect_a_open_id")]
        public string ExpectAOpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("expect_a_user_id")]
        public string ExpectAUserId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("expect_b_id_type_list")]
        public string ExpectBIdTypeList { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("expect_b_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> ExpectBOpenIdList { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("expect_b_user_id_list")]
        [XmlArrayItem("string")]
        public List<string> ExpectBUserIdList { get; set; }
    }
}
