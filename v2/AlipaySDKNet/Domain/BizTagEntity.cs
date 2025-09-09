using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizTagEntity Data Structure.
    /// </summary>
    [Serializable]
    public class BizTagEntity : AopObject
    {
        /// <summary>
        /// 标签扩展参数
        /// </summary>
        [XmlElement("biz_tag_ext_params")]
        public BizTagExtParams BizTagExtParams { get; set; }

        /// <summary>
        /// 前置准入咨询标签
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
