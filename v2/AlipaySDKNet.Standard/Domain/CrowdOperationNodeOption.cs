using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdOperationNodeOption Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdOperationNodeOption : AopObject
    {
        /// <summary>
        /// 节点编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 节点id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 节点值名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 平铺展开的选项值ID
        /// </summary>
        [XmlElement("option_id_list")]
        public string OptionIdList { get; set; }

        /// <summary>
        /// 值列表
        /// </summary>
        [XmlArray("option_list")]
        [XmlArrayItem("crowd_operation_node_option_detail")]
        public List<CrowdOperationNodeOptionDetail> OptionList { get; set; }

        /// <summary>
        /// 平铺展开的选项中文值
        /// </summary>
        [XmlElement("option_text_list")]
        public string OptionTextList { get; set; }

        /// <summary>
        /// 平铺展开的选项值
        /// </summary>
        [XmlElement("option_value_list")]
        public string OptionValueList { get; set; }
    }
}
