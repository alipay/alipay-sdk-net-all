using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierEquitypledgeQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierEquitypledgeQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业股权出质内容
        /// </summary>
        [XmlElement("data")]
        public EpEquityPledgeDataInfo Data { get; set; }

        /// <summary>
        /// 查得标记
        /// </summary>
        [XmlElement("data_found")]
        public bool DataFound { get; set; }
    }
}
