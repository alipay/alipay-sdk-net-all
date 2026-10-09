using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAicsDevinWorkerPageQueryResponse.
    /// </summary>
    public class DatadigitalAicsDevinWorkerPageQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("worker_item")]
        public List<WorkerItem> Data { get; set; }

        /// <summary>
        /// 总分页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 总记录条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
