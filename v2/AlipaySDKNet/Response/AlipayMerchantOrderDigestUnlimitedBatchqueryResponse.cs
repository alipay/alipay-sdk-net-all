using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantOrderDigestUnlimitedBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantOrderDigestUnlimitedBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 是否还有下一页
        /// </summary>
        [XmlElement("has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 下一次请求的end_time（用于分页查询）
        /// </summary>
        [XmlElement("next_end_time")]
        public string NextEndTime { get; set; }

        /// <summary>
        /// 订单信息列表，当存在符合条件的订单时，则返回订单信息；
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("alipay_order_data_openapi_result_info")]
        public List<AlipayOrderDataOpenapiResultInfo> OrderList { get; set; }
    }
}
