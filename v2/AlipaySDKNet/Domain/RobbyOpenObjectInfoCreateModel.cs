using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RobbyOpenObjectInfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class RobbyOpenObjectInfoCreateModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("biz_object_field_info")]
        [XmlArrayItem("object_field_info")]
        public List<ObjectFieldInfo> BizObjectFieldInfo { get; set; }

        /// <summary>
        /// 业务对象库编号
        /// </summary>
        [XmlElement("biz_object_library_no")]
        public string BizObjectLibraryNo { get; set; }

        /// <summary>
        /// 业务对象名称，如药品名称等
        /// </summary>
        [XmlElement("biz_object_name")]
        public string BizObjectName { get; set; }

        /// <summary>
        /// 业务对象编号，如药品 ID、69 码等
        /// </summary>
        [XmlElement("biz_object_no")]
        public string BizObjectNo { get; set; }
    }
}
