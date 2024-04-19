using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingRtaTradeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingRtaTradeQueryModel : AopObject
    {
        /// <summary>
        /// 资源位信息确定商户投放场景，由摩斯同学配置并分配给调用方
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 支付宝交易号，用于摩斯与广告主对账，内容可以是银行流水交易号或者商户交易的唯一标识
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易类型，标识回调的类型，取值为英文，枚举值VERIFY[核销]和REFUND[退货] 如果交易类型为空，返回该订单的最近一条记录
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
