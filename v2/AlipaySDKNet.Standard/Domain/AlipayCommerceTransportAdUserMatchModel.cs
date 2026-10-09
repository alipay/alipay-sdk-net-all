using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdUserMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdUserMatchModel : AopObject
    {
        /// <summary>
        /// 第三方平台用户ID
        /// </summary>
        [XmlElement("third_user_id")]
        public string ThirdUserId { get; set; }
    }
}
