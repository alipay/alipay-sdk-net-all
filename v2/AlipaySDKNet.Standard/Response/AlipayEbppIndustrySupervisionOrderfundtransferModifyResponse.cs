using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionOrderfundtransferModifyResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionOrderfundtransferModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改金额业务状态
        /// </summary>
        [XmlElement("modify_status")]
        public string ModifyStatus { get; set; }

        /// <summary>
        /// 修改的划拨单请求流水号
        /// </summary>
        [XmlElement("out_flow_id")]
        public string OutFlowId { get; set; }

        /// <summary>
        /// 关联订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
