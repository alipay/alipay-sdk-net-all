using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppInstnoticeCheckavailableModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppInstnoticeCheckavailableModel : AopObject
    {
        /// <summary>
        /// 流程的唯一标识，用来查询公告的执行状态，是否生效。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
