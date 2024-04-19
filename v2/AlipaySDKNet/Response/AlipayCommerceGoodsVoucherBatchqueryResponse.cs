using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceGoodsVoucherBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceGoodsVoucherBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 活动信息
        /// </summary>
        [XmlArray("activities")]
        [XmlArrayItem("camp_voucher_info")]
        public List<CampVoucherInfo> Activities { get; set; }
    }
}
