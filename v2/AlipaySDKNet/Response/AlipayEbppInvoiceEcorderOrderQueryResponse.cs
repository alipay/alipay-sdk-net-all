using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEcorderOrderQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEcorderOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业码订单详情
        /// </summary>
        [XmlElement("order_info")]
        public EcOrderItem OrderInfo { get; set; }

        /// <summary>
        /// 企业码子订单详情列表
        /// </summary>
        [XmlArray("sub_order_list")]
        [XmlArrayItem("ec_order_item")]
        public List<EcOrderItem> SubOrderList { get; set; }
    }
}
