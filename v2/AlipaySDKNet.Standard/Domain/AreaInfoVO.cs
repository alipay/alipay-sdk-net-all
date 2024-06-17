using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AreaInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class AreaInfoVO : AopObject
    {
        /// <summary>
        /// 代码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 英文名称
        /// </summary>
        [XmlElement("en_name")]
        public string EnName { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父级代码
        /// </summary>
        [XmlElement("parent_code")]
        public string ParentCode { get; set; }

        /// <summary>
        /// 拼写
        /// </summary>
        [XmlElement("spell")]
        public string Spell { get; set; }
    }
}
