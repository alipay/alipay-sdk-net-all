using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingOrderBatchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingOrderBatchQueryModel : AopObject
    {
        /// <summary>
        /// 创建订单的结束时间，格式：yyyyMMdd
        /// </summary>
        [XmlElement("create_time_end")]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// 创建订单的开始时间，格式：yyyyMMdd
        /// </summary>
        [XmlElement("create_time_start")]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// 订单最近一次更新结束时间，格式：yyyyMMdd 当前字段已废弃(不支持更新时间查询，废弃)
        /// </summary>
        [XmlElement("modify_time_end")]
        public string ModifyTimeEnd { get; set; }

        /// <summary>
        /// 订单最近一次更新开始时间，格式：yyyyMMdd 当前字段已废弃(不支持更新时间查询，废弃)
        /// </summary>
        [XmlElement("modify_time_start")]
        public string ModifyTimeStart { get; set; }

        /// <summary>
        /// 页码，默认 1（可选）
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数，默认 20，最大 1000
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_id_list")]
        [XmlArrayItem("string")]
        public List<string> ShopIdList { get; set; }
    }
}
