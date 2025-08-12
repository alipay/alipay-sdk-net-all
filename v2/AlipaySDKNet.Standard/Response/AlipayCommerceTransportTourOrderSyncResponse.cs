using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTourOrderSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportTourOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("success_order_list")]
        [XmlArrayItem("tour_order_sync_response")]
        public List<TourOrderSyncResponse> SuccessOrderList { get; set; }

        /// <summary>
        /// 失败的订单凭证号。 结构： outBizNum|outVoucherId
        /// </summary>
        [XmlElement("un_sync_order_no_list")]
        public string UnSyncOrderNoList { get; set; }
    }
}
