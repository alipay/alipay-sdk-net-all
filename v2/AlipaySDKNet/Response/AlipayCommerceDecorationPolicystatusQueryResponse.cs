using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDecorationPolicystatusQueryResponse.
    /// </summary>
    public class AlipayCommerceDecorationPolicystatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 核保状态
        /// </summary>
        [XmlElement("policy_status")]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// <a href="https://render.alipay.com/p/h5/inspolicy/www/index.html?policyNo=保单单号">
        /// </summary>
        [XmlElement("policy_url")]
        public string PolicyUrl { get; set; }
    }
}
