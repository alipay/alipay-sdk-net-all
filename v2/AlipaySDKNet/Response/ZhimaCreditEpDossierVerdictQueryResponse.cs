using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierVerdictQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierVerdictQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业裁判文书内容
        /// </summary>
        [XmlElement("data")]
        public EpVerdictDataInfo Data { get; set; }
    }
}
