using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionTransfermaterialSubmitResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionTransfermaterialSubmitResponse : AopResponse
    {
        /// <summary>
        /// 提交划拨单关联凭证处理结果
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_flow_id")]
        public string OutFlowId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
