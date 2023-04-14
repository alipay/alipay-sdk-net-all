using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotIdentityOrgUserRemoveApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class IotIdentityOrgUserRemoveApiResponse : AopObject
    {
        /// <summary>
        /// 入库事件id，后续isv通过该id来查询处理进度
        /// </summary>
        [XmlElement("event_id")]
        public string EventId { get; set; }
    }
}
