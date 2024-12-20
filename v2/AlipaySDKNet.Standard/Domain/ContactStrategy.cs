using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContactStrategy Data Structure.
    /// </summary>
    [Serializable]
    public class ContactStrategy : AopObject
    {
        /// <summary>
        /// 期望拨打时间
        /// </summary>
        [XmlElement("expect_call_time")]
        public string ExpectCallTime { get; set; }

        /// <summary>
        /// 最后拨打时间
        /// </summary>
        [XmlElement("latest_call_time")]
        public string LatestCallTime { get; set; }

        /// <summary>
        /// 手机号类型
        /// </summary>
        [XmlElement("param_type")]
        public string ParamType { get; set; }
    }
}
