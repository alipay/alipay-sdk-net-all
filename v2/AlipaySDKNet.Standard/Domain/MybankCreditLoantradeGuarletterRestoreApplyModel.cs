using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterRestoreApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeGuarletterRestoreApplyModel : AopObject
    {
        /// <summary>
        /// 受益人信息
        /// </summary>
        [XmlElement("beneficiary_user_info")]
        public EnterpriseCustomerInfoVO BeneficiaryUserInfo { get; set; }

        /// <summary>
        /// 标的详情
        /// </summary>
        [XmlElement("bid_detail")]
        public BidDetailVO BidDetail { get; set; }

        /// <summary>
        /// 加密字段解密秘钥
        /// </summary>
        [XmlElement("decrypt_key")]
        public string DecryptKey { get; set; }

        /// <summary>
        /// 担保订单号
        /// </summary>
        [XmlElement("guar_letter_order_no")]
        public string GuarLetterOrderNo { get; set; }

        /// <summary>
        /// 请求单号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 方案合约号
        /// </summary>
        [XmlElement("scheme_ar_no")]
        public string SchemeArNo { get; set; }
    }
}
