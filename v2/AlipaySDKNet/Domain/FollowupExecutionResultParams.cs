using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FollowupExecutionResultParams Data Structure.
    /// </summary>
    [Serializable]
    public class FollowupExecutionResultParams : AopObject
    {
        /// <summary>
        /// 具体见产品线下定义的字段
        /// </summary>
        [XmlElement("params_data")]
        public string ParamsData { get; set; }
    }
}
