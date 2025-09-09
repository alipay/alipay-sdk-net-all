using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FilterChildDataConfig Data Structure.
    /// </summary>
    [Serializable]
    public class FilterChildDataConfig : AopObject
    {
        /// <summary>
        /// 参数值
        /// </summary>
        [XmlElement("param")]
        public string Param { get; set; }

        /// <summary>
        /// 显示文本
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
