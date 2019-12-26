using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantActivityBatchqueryResponse.
    /// </summary>
    public class ZhimaMerchantActivityBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 芝麻承诺消费开放模式活动模型列表
        /// </summary>
        [XmlArray("activity_list")]
        [XmlArrayItem("activity")]
        public List<Activity> ActivityList { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页条目数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 本次查询总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 本次查询总条目数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
