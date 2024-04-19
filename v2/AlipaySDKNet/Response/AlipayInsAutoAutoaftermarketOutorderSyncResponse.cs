using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsAutoAutoaftermarketOutorderSyncResponse.
    /// </summary>
    public class AlipayInsAutoAutoaftermarketOutorderSyncResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁生成的订单号，跟服务商的订单号做一一映射
        /// </summary>
        [XmlElement("ant_order_no")]
        public string AntOrderNo { get; set; }
    }
}
