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
        /// 保司保单号
        /// </summary>
        [XmlElement("inst_policy_no")]
        public string InstPolicyNo { get; set; }

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
        /// 枚举值： 核保受理 :PENDING 核保成功:UNDERWRITING_SUCCESS 核保失败 :UNDERWRITING_FAILURE 承保成功:POLICY_ISSUED_SUCCESS 承保失败:POLICY_ISSUED_FAILURE 已退保:POLICY_CANCELLED 退保受理:SURRENDER_PENDING 退保失败:SURRENDER_ FAILURE
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
