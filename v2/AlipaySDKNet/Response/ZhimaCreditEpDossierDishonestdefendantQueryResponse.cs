using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierDishonestdefendantQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierDishonestdefendantQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业失信被执行人内容
        /// </summary>
        [XmlElement("data")]
        public EpDishonestDefendantDataInfo Data { get; set; }
    }
}
