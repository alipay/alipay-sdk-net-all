using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierBondratingQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierBondratingQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("data")]
        public ZmEpBondRatingDataInfo Data { get; set; }
    }
}
