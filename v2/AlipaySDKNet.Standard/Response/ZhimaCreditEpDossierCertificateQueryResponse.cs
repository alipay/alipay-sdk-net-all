using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierCertificateQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierCertificateQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("data")]
        public ZmepCertificateDataInfo Data { get; set; }
    }
}
