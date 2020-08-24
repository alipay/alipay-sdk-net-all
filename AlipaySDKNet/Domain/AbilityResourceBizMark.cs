using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AbilityResourceBizMark Data Structure.
    /// </summary>
    [Serializable]
    public class AbilityResourceBizMark : AopObject
    {
        /// <summary>
        /// isv的业务code,商户可以用户这个code和商户进行数据核对
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// executionTime
        /// </summary>
        [XmlElement("execution_time")]
        public string ExecutionTime { get; set; }
    }
}
