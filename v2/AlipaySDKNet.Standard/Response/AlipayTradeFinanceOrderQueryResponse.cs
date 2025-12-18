using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeFinanceOrderQueryResponse.
    /// </summary>
    public class AlipayTradeFinanceOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 金融服务子单列表
        /// </summary>
        [XmlArray("finance_bill_list")]
        [XmlArrayItem("finance_bill_info")]
        public List<FinanceBillInfo> FinanceBillList { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝金融服务订单号
        /// </summary>
        [XmlElement("settlement_no")]
        public string SettlementNo { get; set; }
    }
}
