using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleOrderDelegateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleOrderDelegateBatchqueryModel : AopObject
    {
        /// <summary>
        /// 淘宝品牌店铺：BRAND
        /// </summary>
        [XmlElement("delegate_type")]
        public string DelegateType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 回收主订单状态。详见回收订单状态机 当前字段已废弃(调整字段为数组类型调整字段为数组类型)
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 过滤的回收状态
        /// </summary>
        [XmlArray("order_status_list")]
        [XmlArrayItem("string")]
        public List<string> OrderStatusList { get; set; }

        /// <summary>
        /// 起始页码为1
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小，最大限制20条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 不传入则不进行行业类目过滤. 行业类目详见回收行业类目枚举
        /// </summary>
        [XmlArray("recycle_category_list")]
        [XmlArrayItem("string")]
        public List<string> RecycleCategoryList { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
