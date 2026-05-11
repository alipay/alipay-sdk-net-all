using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceQhinsclaimSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceQhinsclaimSyncModel : AopObject
    {
        /// <summary>
        /// 请求入参
        /// </summary>
        [XmlElement("request_str")]
        public string RequestStr { get; set; }
    }
}
