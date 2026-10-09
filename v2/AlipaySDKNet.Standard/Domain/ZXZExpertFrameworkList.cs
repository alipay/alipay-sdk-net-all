using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZXZExpertFrameworkList Data Structure.
    /// </summary>
    [Serializable]
    public class ZXZExpertFrameworkList : AopObject
    {
        /// <summary>
        /// 专家框架列表
        /// </summary>
        [XmlArray("framework_list")]
        [XmlArrayItem("fin_framework_detail")]
        public List<FinFrameworkDetail> FrameworkList { get; set; }

        /// <summary>
        /// 专家框架所属的大类列表,这里返回的是名称。请直接使用名称展示即可，。无须code
        /// </summary>
        [XmlElement("type_name")]
        public string TypeName { get; set; }
    }
}
