using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DumpPageRes Data Structure.
    /// </summary>
    [Serializable]
    public class DumpPageRes : AopObject
    {
        /// <summary>
        /// 元素为单个dump任务的信息
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("ocp_cloud_sql_dump_task_res")]
        public List<OcpCloudSqlDumpTaskRes> List { get; set; }

        /// <summary>
        /// 任务总数量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
