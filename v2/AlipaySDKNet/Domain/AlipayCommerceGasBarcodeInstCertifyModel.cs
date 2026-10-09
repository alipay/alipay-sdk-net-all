using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceGasBarcodeInstCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceGasBarcodeInstCertifyModel : AopObject
    {
        /// <summary>
        /// 机构的会员编号
        /// </summary>
        [XmlElement("member_no")]
        public string MemberNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
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
