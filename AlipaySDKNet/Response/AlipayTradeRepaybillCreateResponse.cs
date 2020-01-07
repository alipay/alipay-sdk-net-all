using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeRepaybillCreateResponse.
    /// </summary>
    public class AlipayTradeRepaybillCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝账单编号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }
    }
}
