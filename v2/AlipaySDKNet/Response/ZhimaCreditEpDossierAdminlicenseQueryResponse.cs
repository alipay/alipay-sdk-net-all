using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierAdminlicenseQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierAdminlicenseQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业行政许可内容
        /// </summary>
        [XmlElement("data")]
        public EpAdminLicenseDataInfo Data { get; set; }
    }
}
