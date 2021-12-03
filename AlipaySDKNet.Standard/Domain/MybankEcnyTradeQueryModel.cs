using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyTradeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyTradeQueryModel : AopObject
    {
        /// <summary>
        /// 调用方单号 商户订单号和运营机构交易号不能同时为空。 trade_no,out_trade_no如果同时存在优先取trade_no
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 运营机构交易号，和商户订单号不能同时为空
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
