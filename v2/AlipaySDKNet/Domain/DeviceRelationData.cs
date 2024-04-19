using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceRelationData Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceRelationData : AopObject
    {
        /// <summary>
        /// 生效计划id列表
        /// </summary>
        [XmlArray("plan_id_list")]
        [XmlArrayItem("number")]
        public List<long> PlanIdList { get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
