using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FeedbackRecord Data Structure.
    /// </summary>
    [Serializable]
    public class FeedbackRecord : AopObject
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("record_type")]
        public string RecordType { get; set; }

        /// <summary>
        /// "click"： 点击、 "show"：曝光
        /// </summary>
        [XmlElement("type_list")]
        public string TypeList { get; set; }
    }
}
