using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierConsumerestrictionQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierConsumerestrictionQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业限制高消费内容
        /// </summary>
        [XmlElement("data")]
        public EpConsumeRestrictionDataInfo Data { get; set; }
    }
}
