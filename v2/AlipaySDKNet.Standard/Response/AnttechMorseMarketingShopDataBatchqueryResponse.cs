using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingShopDataBatchqueryResponse.
    /// </summary>
    public class AnttechMorseMarketingShopDataBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 数据列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("shop_data_detail")]
        public List<ShopDataDetail> DataList { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 总数，用于分页
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
