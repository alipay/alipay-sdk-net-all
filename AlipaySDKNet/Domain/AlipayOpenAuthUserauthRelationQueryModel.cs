using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthUserauthRelationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthUserauthRelationQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
