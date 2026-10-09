using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoAgreementUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeZmgoAgreementUnsignModel : AopObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝的用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝的用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// quit_type为USER_CANCEL_QUIT或者SETTLE_APPLY_QUIT
        /// </summary>
        [XmlElement("quit_type")]
        public string QuitType { get; set; }
    }
}
