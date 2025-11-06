using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTourIdentityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTourIdentityQueryModel : AopObject
    {
        /// <summary>
        /// 会话信息 
        /// </summary>
        [XmlElement("code_token")]
        public string CodeToken { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("identity_type_list")]
        [XmlArrayItem("string")]
        public List<string> IdentityTypeList { get; set; }

        /// <summary>
        /// 支付宝用户的userId。 
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。 
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
