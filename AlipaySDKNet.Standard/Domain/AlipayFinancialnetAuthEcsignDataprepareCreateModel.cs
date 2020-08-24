using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignDataprepareCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthEcsignDataprepareCreateModel : AopObject
    {
        /// <summary>
        /// 签约结束回跳地址
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 签约时所需要的数据信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 跳转类型
        /// </summary>
        [XmlElement("jump_type")]
        public string JumpType { get; set; }

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
