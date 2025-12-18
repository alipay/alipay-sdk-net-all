using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeFinanceOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeFinanceOrderQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝金融服务订单号（alipay.trade.finance.precreate接口返回settlement_no）
        /// </summary>
        [XmlElement("settlement_no")]
        public string SettlementNo { get; set; }
    }
}
