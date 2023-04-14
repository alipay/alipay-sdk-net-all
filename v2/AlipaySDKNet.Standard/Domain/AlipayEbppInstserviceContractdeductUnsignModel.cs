using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInstserviceContractdeductUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInstserviceContractdeductUnsignModel : AopObject
    {
        /// <summary>
        /// 代扣签约协议号
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 用户户号
        /// </summary>
        [XmlElement("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 支付宝用户的openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户签约的支付宝账号id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
