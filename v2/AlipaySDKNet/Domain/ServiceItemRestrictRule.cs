using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceItemRestrictRule Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceItemRestrictRule : AopObject
    {
        /// <summary>
        /// 限制类型，手机号、证件类型、证件号
        /// </summary>
        [XmlElement("restrict_type")]
        public string RestrictType { get; set; }

        /// <summary>
        /// 服务项ID
        /// </summary>
        [XmlElement("service_item_id")]
        public string ServiceItemId { get; set; }

        /// <summary>
        /// 用户证件号
        /// </summary>
        [XmlArray("user_cert_no_list")]
        [XmlArrayItem("string")]
        public List<string> UserCertNoList { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlArray("user_cert_type_list")]
        [XmlArrayItem("string")]
        public List<string> UserCertTypeList { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlArray("user_phone_no_list")]
        [XmlArrayItem("string")]
        public List<string> UserPhoneNoList { get; set; }
    }
}
