using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceQhinsclaimSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceQhinsclaimSyncResponse : AopResponse
    {
        /// <summary>
        /// 响应出参
        /// </summary>
        [XmlElement("response_str")]
        public string ResponseStr { get; set; }
    }
}
