using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceGroup Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceGroup : AopObject
    {
        /// <summary>
        /// 服务分组的id.目前只有首页底部服务
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 服务分组名称。目前只有首页底部
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 服务展位code.适用获取光华服务配置
        /// </summary>
        [XmlElement("position_code")]
        public string PositionCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_list")]
        [XmlArrayItem("agent_service_info")]
        public List<AgentServiceInfo> ServiceList { get; set; }
    }
}
