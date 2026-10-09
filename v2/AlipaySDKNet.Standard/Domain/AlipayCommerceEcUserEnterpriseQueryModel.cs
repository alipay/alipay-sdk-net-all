using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcUserEnterpriseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcUserEnterpriseQueryModel : AopObject
    {
        /// <summary>
        /// 用户open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
