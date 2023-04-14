using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationTerminalPowerbankorderFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationTerminalPowerbankorderFinishModel : AopObject
    {
        /// <summary>
        /// 完结订单时在哪个设备
        /// </summary>
        [XmlElement("extra_param")]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 需要更新的记录外部订单号
        /// </summary>
        [XmlElement("out_trade_id")]
        public string OutTradeId { get; set; }

        /// <summary>
        /// 进件过的,且之前生成了对应订单记录的设备序列号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 完结时,对应记录状态,只能是FINISHED(订单成功完结且扣款成功)或者PAY_FAIL(订单完结但扣款失败)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 预授权转交易,收单时的交易Id
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }
    }
}
