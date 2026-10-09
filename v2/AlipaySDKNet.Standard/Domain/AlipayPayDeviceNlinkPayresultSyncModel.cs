using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayDeviceNlinkPayresultSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayDeviceNlinkPayresultSyncModel : AopObject
    {
        /// <summary>
        /// 动态码token
        /// </summary>
        [XmlElement("ntoken")]
        public string Ntoken { get; set; }

        /// <summary>
        /// 返回业务数据
        /// </summary>
        [XmlElement("open_pay_result")]
        public OpenPayResult OpenPayResult { get; set; }

        /// <summary>
        /// 付款码
        /// </summary>
        [XmlElement("paycode")]
        public string Paycode { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
