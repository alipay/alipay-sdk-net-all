using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataZbdmLineageQueryResponse.
    /// </summary>
    public class AlipayDataZbdmLineageQueryResponse : AopResponse
    {
        /// <summary>
        /// 参数名：返回血缘探索的边集合 应用场景：返回边的起始id，终止id已经反向 如何获取：geabase中获取
        /// </summary>
        [XmlArray("edges")]
        [XmlArrayItem("string")]
        public List<string> Edges { get; set; }

        /// <summary>
        /// 参数名:返回血缘探索的点集合 应用场景:返回一张表/字段上下游20层以内的表/字段 如何获取：从geabase中获取
        /// </summary>
        [XmlArray("vertices")]
        [XmlArrayItem("string")]
        public List<string> Vertices { get; set; }
    }
}
