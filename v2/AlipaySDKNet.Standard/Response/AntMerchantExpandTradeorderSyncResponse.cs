using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandTradeorderSyncResponse.
    /// </summary>
    public class AntMerchantExpandTradeorderSyncResponse : AopResponse
    {
        /// <summary>
        /// 订单创建成功后返回的id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
