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
        /// 签约请求代理模式，说明被代理的对象，其中proxiedPid是被代理的商户的PID，非UID
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

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
