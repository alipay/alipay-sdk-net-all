using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAqTokenCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAqTokenCancelModel : AopObject
    {
        /// <summary>
        /// 支付宝openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
