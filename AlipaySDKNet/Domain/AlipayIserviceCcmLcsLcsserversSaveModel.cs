using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmLcsLcsserversSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmLcsLcsserversSaveModel : AopObject
    {
        /// <summary>
        /// 轻聊客服数据添加类型
        /// </summary>
        [XmlElement("add_type")]
        public string AddType { get; set; }

        /// <summary>
        /// 租户实例id（数据权限id），不填，则使用默认的租户实例id
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 客服ID列表
        /// </summary>
        [XmlArray("server_ids")]
        [XmlArrayItem("number")]
        public List<long> ServerIds { get; set; }
    }
}
