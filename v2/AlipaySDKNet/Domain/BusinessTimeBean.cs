using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessTimeBean Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessTimeBean : AopObject
    {
        /// <summary>
        /// 停止营业时间
        /// </summary>
        [XmlElement("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// 开始营业时间
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }
    }
}
