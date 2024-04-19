using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarRentcarOutorderSyncResponse.
    /// </summary>
    public class AlipayEcoMycarRentcarOutorderSyncResponse : AopResponse
    {
        /// <summary>
        /// 订单同步到支付宝车生活后生成的车生活订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
