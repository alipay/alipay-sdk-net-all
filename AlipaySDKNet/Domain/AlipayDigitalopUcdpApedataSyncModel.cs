using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApedataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApedataSyncModel : AopObject
    {
        /// <summary>
        /// 同步数据的列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("ape_data_item")]
        public List<ApeDataItem> DataList { get; set; }

        /// <summary>
        /// 数据类型，可选值：USER（用户数据）、ITEM（商品数据）、BEHAVIOR（行为数据）
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 商家在蚂蚁推荐引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
