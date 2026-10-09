using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionPayCancelResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionPayCancelResponse : AopResponse
    {
        /// <summary>
        /// 关闭结果
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 外部流水号，本次创建支付单的请求id，重复请求幂等返回
        /// </summary>
        [XmlElement("out_flow_id")]
        public string OutFlowId { get; set; }

        /// <summary>
        /// 外部订单号，本次发起支付关联的冻资单id
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝创建的内部支付单号。后续后续根据流水号或者外部订单号查询。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
