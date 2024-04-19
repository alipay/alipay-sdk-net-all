using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseRollbacktaskdetailQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseDatabaseRollbacktaskdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 回档任务执行明细列表
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("mongo_rollback_task_detail")]
        public List<MongoRollbackTaskDetail> Details { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
