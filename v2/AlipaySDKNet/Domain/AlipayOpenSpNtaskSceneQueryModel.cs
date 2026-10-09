using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNtaskSceneQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNtaskSceneQueryModel : AopObject
    {
        /// <summary>
        /// 用于查询时真正使用的参数值
        /// </summary>
        [XmlArray("batch_query_param")]
        [XmlArrayItem("string")]
        public List<string> BatchQueryParam { get; set; }

        /// <summary>
        /// 该参数决定用什么类型的参数去查询
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 该参数用于指定查询的数据是设备作业数据还是线圈作业数据
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
