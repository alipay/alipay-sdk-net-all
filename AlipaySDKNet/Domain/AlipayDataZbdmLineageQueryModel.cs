using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataZbdmLineageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataZbdmLineageQueryModel : AopObject
    {
        /// <summary>
        /// 参数名：血缘传播方向 应用场景：血缘探索的方向，forward-正向；backward-反向 如何获取：业务传入
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 参数名：血缘传播的边类型 应用场景：表涉及的边类型为：["table_depend_table"] 字段涉及的边类型为：["field_depend_field","field_influ_field"] 如何获取： 业务方传入
        /// </summary>
        [XmlArray("edge_type")]
        [XmlArrayItem("string")]
        public List<string> EdgeType { get; set; }

        /// <summary>
        /// 参数名：血缘探索的最大深度 应用场景：血缘探索的最大深度，超过最大深度将终止探索 如何获取：业务方传入，默认可以是20
        /// </summary>
        [XmlElement("max_depth")]
        public long MaxDepth { get; set; }

        /// <summary>
        /// 参数名: 表或者字段的guid集合 应用场景：输入要查询的表或者字段的guid 如何获取：业务方传入-表：odps.projectname.tablename;字段：odps.projectname.tablename.fieldname
        /// </summary>
        [XmlArray("start_ids")]
        [XmlArrayItem("string")]
        public List<string> StartIds { get; set; }
    }
}
