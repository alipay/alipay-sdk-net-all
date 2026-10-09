using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniTipsDeliveryBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniTipsDeliveryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 收藏引导活动信息列表。根据活动状态排序，顺序为：生效中，暂停，审核中，白名单生效中，初始化，审核失败，结束。相同状态优先展示状态更新时间最迟的活动。
        /// </summary>
        [XmlArray("tips_delivery_list")]
        [XmlArrayItem("tips_delivery")]
        public List<TipsDelivery> TipsDeliveryList { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 收藏引导数据总数量
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
