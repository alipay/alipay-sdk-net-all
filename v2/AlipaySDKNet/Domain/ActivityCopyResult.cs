using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityCopyResult Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityCopyResult : AopObject
    {
        /// <summary>
        /// 活动权益复制内容，和入参中copy_content相对应，表示其执行结果
        /// </summary>
        [XmlElement("copy_content")]
        public string CopyContent { get; set; }

        /// <summary>
        /// 本对象中copy_content所对应的活动权益复制失败原因，当result=fail时本字段才有值
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 本对象中copy_content所对应的活动权益复制结果，值为success和fail
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
