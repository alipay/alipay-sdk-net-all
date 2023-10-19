using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalCrmmsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalCrmmsgSendModel : AopObject
    {
        /// <summary>
        /// 入参
        /// </summary>
        [XmlElement("crm_notify_request")]
        public string CrmNotifyRequest { get; set; }
    }
}
