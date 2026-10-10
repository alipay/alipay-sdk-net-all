using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObjectItem Data Structure.
    /// </summary>
    [Serializable]
    public class ObjectItem : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("biz_object_field_info")]
        [XmlArrayItem("key_value_fields")]
        public List<KeyValueFields> BizObjectFieldInfo { get; set; }

        /// <summary>
        /// 业务对象名称
        /// </summary>
        [XmlElement("biz_object_name")]
        public string BizObjectName { get; set; }

        /// <summary>
        /// 业务对象编号（如69码）
        /// </summary>
        [XmlElement("biz_object_no")]
        public string BizObjectNo { get; set; }
    }
}
