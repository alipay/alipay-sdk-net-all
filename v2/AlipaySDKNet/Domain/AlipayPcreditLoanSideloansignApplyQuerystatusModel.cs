using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanSideloansignApplyQuerystatusModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanSideloansignApplyQuerystatusModel : AopObject
    {
        /// <summary>
        /// 用户支付宝ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 阿里授信申请单号
        /// </summary>
        [XmlElement("credit_apply_no")]
        public string CreditApplyNo { get; set; }

        /// <summary>
        /// 扩展字段，预留
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁借贷款产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
