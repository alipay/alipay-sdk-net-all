using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsShopBusinessTime Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsShopBusinessTime : AopObject
    {
        /// <summary>
        /// 营业开始时间，格式如示例值
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 营业结束时间，格式如示例值
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }
    }
}
