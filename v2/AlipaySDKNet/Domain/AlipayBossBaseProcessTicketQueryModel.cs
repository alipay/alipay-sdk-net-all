using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessTicketQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessTicketQueryModel : AopObject
    {
        /// <summary>
        /// 流程实例Id
        /// </summary>
        [XmlElement("puid")]
        public string Puid { get; set; }
    }
}
