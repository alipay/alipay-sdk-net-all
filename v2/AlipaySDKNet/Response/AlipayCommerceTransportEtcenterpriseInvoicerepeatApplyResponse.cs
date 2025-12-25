using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseInvoicerepeatApplyResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcenterpriseInvoicerepeatApplyResponse : AopResponse
    {
        /// <summary>
        /// 匹配到的交易
        /// </summary>
        [XmlArray("trade_list")]
        [XmlArrayItem("etc_inovice_repeat_trade_list")]
        public List<EtcInoviceRepeatTradeList> TradeList { get; set; }
    }
}
