using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcInvoiceMerchantproductApplyResponse.
    /// </summary>
    public class AlipayCommerceEcInvoiceMerchantproductApplyResponse : AopResponse
    {
        /// <summary>
        /// 产品开通流水ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 产品开通状态
        /// </summary>
        [XmlElement("flow_status")]
        public string FlowStatus { get; set; }

        /// <summary>
        /// 开通流程页(需要商户登录)
        /// </summary>
        [XmlElement("open_page_url")]
        public string OpenPageUrl { get; set; }

        /// <summary>
        /// 外部申请ID
        /// </summary>
        [XmlElement("out_apply_id")]
        public string OutApplyId { get; set; }
    }
}
