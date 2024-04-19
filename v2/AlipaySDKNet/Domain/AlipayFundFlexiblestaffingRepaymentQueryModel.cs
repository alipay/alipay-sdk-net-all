using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundFlexiblestaffingRepaymentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundFlexiblestaffingRepaymentQueryModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 借款订单号
        /// </summary>
        [XmlElement("fund_order_id")]
        public string FundOrderId { get; set; }

        /// <summary>
        /// 借款协议号
        /// </summary>
        [XmlElement("loan_agreement_no")]
        public string LoanAgreementNo { get; set; }

        /// <summary>
        /// 外部唯一订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
