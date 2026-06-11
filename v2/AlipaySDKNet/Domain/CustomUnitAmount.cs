using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomUnitAmount Data Structure.
    /// </summary>
    [Serializable]
    public class CustomUnitAmount : AopObject
    {
        /// <summary>
        /// 是否启用灵活定价，启用后可设置 preset、maximum、minimum 字段
        /// </summary>
        [XmlElement("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 可自定义的最大金额（单位：分），灵活定价开启后可设置
        /// </summary>
        [XmlElement("maximum")]
        public long Maximum { get; set; }

        /// <summary>
        /// 可自定义的最小金额（单位：分），灵活定价开启后可设置
        /// </summary>
        [XmlElement("minimum")]
        public long Minimum { get; set; }

        /// <summary>
        /// 预设的自定义价格（单位：分），灵活定价开启后可设置
        /// </summary>
        [XmlElement("preset")]
        public long Preset { get; set; }
    }
}
