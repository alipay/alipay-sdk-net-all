using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicAccountQueryModel : AopObject
    {
        /// <summary>
        /// 用户的支付宝用户号，2088开头。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
