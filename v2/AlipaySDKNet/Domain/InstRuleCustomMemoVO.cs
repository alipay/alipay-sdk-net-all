using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstRuleCustomMemoVO Data Structure.
    /// </summary>
    [Serializable]
    public class InstRuleCustomMemoVO : AopObject
    {
        /// <summary>
        /// 备注要素
        /// </summary>
        [XmlArray("element_list")]
        [XmlArrayItem("memo_element")]
        public List<MemoElement> ElementList { get; set; }

        /// <summary>
        /// 连接符，默认为空字符串
        /// </summary>
        [XmlElement("split_str")]
        public string SplitStr { get; set; }
    }
}
