using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierCopyrightQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierCopyrightQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询著作权内容
        /// </summary>
        [XmlElement("data")]
        public EpCopyrightDataInfo Data { get; set; }
    }
}
