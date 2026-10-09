using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSettleEfundUnfreezeResponse.
    /// </summary>
    public class AlipayTradeSettleEfundUnfreezeResponse : AopResponse
    {
        /// <summary>
        /// 实际解冻金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("operation_time")]
        public string OperationTime { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付宝结算单据号
        /// </summary>
        [XmlElement("settle_no")]
        public string SettleNo { get; set; }
    }
}
