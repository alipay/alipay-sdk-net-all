using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierReginfochangeQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierReginfochangeQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业工商变更内容信息
        /// </summary>
        [XmlElement("data")]
        public EpReginfoChangeDataInfo Data { get; set; }
    }
}
