using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierBasicinfoQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierBasicinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业工商基本信息
        /// </summary>
        [XmlElement("data")]
        public EpBusinessBasicInfo Data { get; set; }
    }
}
