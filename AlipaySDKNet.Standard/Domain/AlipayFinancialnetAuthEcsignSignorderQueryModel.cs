using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignSignorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthEcsignSignorderQueryModel : AopObject
    {
        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 合作伙伴ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [XmlElement("sign_product_id")]
        public string SignProductId { get; set; }

        /// <summary>
        /// 签约方案码
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
