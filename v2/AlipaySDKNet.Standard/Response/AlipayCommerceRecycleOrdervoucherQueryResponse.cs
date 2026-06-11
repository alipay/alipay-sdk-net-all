using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleOrdervoucherQueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleOrdervoucherQueryResponse : AopResponse
    {
        /// <summary>
        /// 券列表
        /// </summary>
        [XmlArray("voucher_list")]
        [XmlArrayItem("recycle_order_voucher")]
        public List<RecycleOrderVoucher> VoucherList { get; set; }
    }
}
