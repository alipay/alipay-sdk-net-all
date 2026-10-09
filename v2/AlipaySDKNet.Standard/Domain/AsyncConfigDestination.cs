using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AsyncConfigDestination Data Structure.
    /// </summary>
    [Serializable]
    public class AsyncConfigDestination : AopObject
    {
        /// <summary>
        /// 目标类型
        /// </summary>
        [XmlElement("destination_type")]
        public string DestinationType { get; set; }

        /// <summary>
        /// 目标函数名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }
    }
}
