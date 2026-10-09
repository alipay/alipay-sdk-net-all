using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoAgreementSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeZmgoAgreementSignModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 开放ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 芝麻GO预创单号
        /// </summary>
        [XmlElement("preorder_no")]
        public string PreorderNo { get; set; }
    }
}
