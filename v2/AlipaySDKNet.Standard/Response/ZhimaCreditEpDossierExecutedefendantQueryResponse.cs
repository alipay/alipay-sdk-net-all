using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierExecutedefendantQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierExecutedefendantQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业被执行人内容
        /// </summary>
        [XmlElement("data")]
        public EpExecuteDefendantDataInfo Data { get; set; }
    }
}
