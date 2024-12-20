using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierTrademarkQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierTrademarkQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业商标查询内容
        /// </summary>
        [XmlElement("data")]
        public EpTrademarkDataInfo Data { get; set; }
    }
}
