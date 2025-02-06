using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierBiddingQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierBiddingQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("data")]
        public ZmepBiddingDataInfo Data { get; set; }
    }
}
