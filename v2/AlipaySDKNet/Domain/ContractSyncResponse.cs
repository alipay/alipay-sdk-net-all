using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractSyncResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ContractSyncResponse : AopObject
    {
        /// <summary>
        /// 合同中心受理id
        /// </summary>
        [XmlElement("accept_id")]
        public string AcceptId { get; set; }
    }
}
