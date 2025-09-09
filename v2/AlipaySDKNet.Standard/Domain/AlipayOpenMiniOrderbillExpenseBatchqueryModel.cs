using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderbillExpenseBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderbillExpenseBatchqueryModel : AopObject
    {
        /// <summary>
        /// 支付宝交易号列表，最多10个
        /// </summary>
        [XmlArray("trade_no_list")]
        [XmlArrayItem("string")]
        public List<string> TradeNoList { get; set; }
    }
}
