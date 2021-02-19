using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromotePageData Data Structure.
    /// </summary>
    [Serializable]
    public class PromotePageData : AopObject
    {
        /// <summary>
        /// 留资流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 留资属性实例数据列表
        /// </summary>
        [XmlArray("property_list")]
        [XmlArrayItem("promote_page_property_instance")]
        public List<PromotePagePropertyInstance> PropertyList { get; set; }
    }
}
