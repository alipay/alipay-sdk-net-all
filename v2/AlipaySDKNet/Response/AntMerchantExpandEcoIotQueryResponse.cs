using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandEcoIotQueryResponse.
    /// </summary>
    public class AntMerchantExpandEcoIotQueryResponse : AopResponse
    {
        /// <summary>
        /// 生态供应商音箱订单信息
        /// </summary>
        [XmlArray("eco_iot_orders")]
        [XmlArrayItem("asset_eco_iot_order_info")]
        public List<AssetEcoIotOrderInfo> EcoIotOrders { get; set; }

        /// <summary>
        /// 是否还有下一页 true:是;false:否
        /// </summary>
        [XmlElement("has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 生态供应商音箱订单数据总记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
