using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtPoQueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtPoQueryResponse : AopResponse
    {
        /// <summary>
        /// 采购订单信息
        /// </summary>
        [XmlArray("purchase_order_list")]
        [XmlArrayItem("purchase_order_out_d_t_o")]
        public List<PurchaseOrderOutDTO> PurchaseOrderList { get; set; }
    }
}
