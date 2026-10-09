using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalCrmworkstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalCrmworkstatusQueryModel : AopObject
    {
        /// <summary>
        /// 参数必填
        /// </summary>
        [XmlElement("crm_query_worker_suspended_status_request")]
        public string CrmQueryWorkerSuspendedStatusRequest { get; set; }
    }
}
