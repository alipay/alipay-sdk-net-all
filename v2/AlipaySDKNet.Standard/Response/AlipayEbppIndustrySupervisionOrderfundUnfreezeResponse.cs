using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionOrderfundUnfreezeResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionOrderfundUnfreezeResponse : AopResponse
    {
        /// <summary>
        /// 订单金额，整数，单位分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 行业内部受理当前请求后的受理操作单号。
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 请求参数中的外部流水号
        /// </summary>
        [XmlElement("out_flow_id")]
        public string OutFlowId { get; set; }

        /// <summary>
        /// 请求参数中的外部订单号
        /// </summary>
        [XmlElement("relation_out_order_no")]
        public string RelationOutOrderNo { get; set; }
    }
}
