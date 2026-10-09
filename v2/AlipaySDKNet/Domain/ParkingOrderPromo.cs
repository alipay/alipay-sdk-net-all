using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParkingOrderPromo Data Structure.
    /// </summary>
    [Serializable]
    public class ParkingOrderPromo : AopObject
    {
        /// <summary>
        /// 停车交易返佣pid
        /// </summary>
        [XmlElement("agent_pid")]
        public string AgentPid { get; set; }
    }
}
