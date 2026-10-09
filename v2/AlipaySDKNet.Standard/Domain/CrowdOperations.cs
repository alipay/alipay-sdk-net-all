using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdOperations Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdOperations : AopObject
    {
        /// <summary>
        /// 人群ID
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 操作失效的时间戳，13位，消息接收方自转成long类型
        /// </summary>
        [XmlElement("deadline")]
        public string Deadline { get; set; }

        /// <summary>
        /// 操作，1: 加人群 2： 从人群移除
        /// </summary>
        [XmlElement("operator")]
        public long Operator { get; set; }

        /// <summary>
        /// 操作失效的相对间隔时间，优先级高于deadline，消息接受方可自转类型
        /// </summary>
        [XmlElement("ttl")]
        public string Ttl { get; set; }
    }
}
