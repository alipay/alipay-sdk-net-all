using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LabelUpdateDetail Data Structure.
    /// </summary>
    [Serializable]
    public class LabelUpdateDetail : AopObject
    {
        /// <summary>
        /// 传毫秒时间戳，用于数据时序版本控制
        /// </summary>
        [XmlElement("biz_timestamp")]
        public long BizTimestamp { get; set; }

        /// <summary>
        /// 获取方式参考图灵->标签详情页->数据源字段
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }
    }
}
