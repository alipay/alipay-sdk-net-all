using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonAgreementUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonAgreementUnsignModel : AopObject
    {
        /// <summary>
        /// 与签约传值相同
        /// </summary>
        [XmlElement("agreement_code")]
        public string AgreementCode { get; set; }

        /// <summary>
        /// 解约时间，毫秒级时间戳
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 用户在app_id下的唯一id，请优先使用open_id，user_id将逐步下线
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部签约号，与签约时传值相同
        /// </summary>
        [XmlElement("out_sign_no")]
        public string OutSignNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
