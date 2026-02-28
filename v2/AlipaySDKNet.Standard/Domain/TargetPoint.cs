using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TargetPoint Data Structure.
    /// </summary>
    [Serializable]
    public class TargetPoint : AopObject
    {
        /// <summary>
        /// 目标点编号，如图层类型编号
        /// </summary>
        [XmlElement("target_no")]
        public string TargetNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("target_no_attributes")]
        [XmlArrayItem("target_key_value")]
        public List<TargetKeyValue> TargetNoAttributes { get; set; }
    }
}
