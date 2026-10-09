using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradePayeeArConsultResponse.
    /// </summary>
    public class MybankCreditLoantradePayeeArConsultResponse : AopResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 准入的支付宝登录号
        /// </summary>
        [XmlElement("admit_alipay_login_id")]
        public string AdmitAlipayLoginId { get; set; }

        /// <summary>
        /// 准入支付宝UID-映射开放id
        /// </summary>
        [XmlElement("admit_alipay_open_id")]
        public string AdmitAlipayOpenId { get; set; }

        /// <summary>
        /// 准入支付宝UID
        /// </summary>
        [XmlElement("admit_alipay_user_id")]
        public string AdmitAlipayUserId { get; set; }

        /// <summary>
        /// 是否已签约
        /// </summary>
        [XmlElement("is_signed")]
        public bool IsSigned { get; set; }

        /// <summary>
        /// admit为false时才会出现拒绝信息
        /// </summary>
        [XmlElement("refuse_info")]
        public CreditPayRefuseVO RefuseInfo { get; set; }

        /// <summary>
        /// 卖家方案合约号
        /// </summary>
        [XmlElement("scheme_ar_no")]
        public string SchemeArNo { get; set; }

        /// <summary>
        /// 签约引导URL
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
