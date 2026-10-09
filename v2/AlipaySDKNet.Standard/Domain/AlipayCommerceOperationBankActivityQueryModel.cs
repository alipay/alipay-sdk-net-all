using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationBankActivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationBankActivityQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
