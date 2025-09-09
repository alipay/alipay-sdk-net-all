using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunAppserviceBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunAppserviceBatchqueryModel : AopObject
    {
        /// <summary>
        /// 应用服务的唯一标识
        /// </summary>
        [XmlElement("app_service_uuid")]
        public string AppServiceUuid { get; set; }
    }
}
