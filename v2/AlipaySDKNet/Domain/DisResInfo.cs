using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DisResInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DisResInfo : AopObject
    {
        /// <summary>
        /// 业务自定义结构化数据，不同 action 可携带不同业务数据
        /// </summary>
        [XmlElement("data")]
        public DataInfo Data { get; set; }

        /// <summary>
        /// 反馈文案，如完结时填写处理结果说明，拒绝时填写拒绝原因
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
