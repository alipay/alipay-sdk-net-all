using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityShopBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingActivityShopBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 分页查询页码。
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 可用门店列表
        /// </summary>
        [XmlArray("shop_infos")]
        [XmlArrayItem("activity_shop_info")]
        public List<ActivityShopInfo> ShopInfos { get; set; }

        /// <summary>
        /// 可用门店总数量
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
