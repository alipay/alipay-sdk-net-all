using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierAdminpenaltyQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierAdminpenaltyQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业行政处罚内容
        /// </summary>
        [XmlElement("data")]
        public EpAdminPenaltyDataInfo Data { get; set; }
    }
}
