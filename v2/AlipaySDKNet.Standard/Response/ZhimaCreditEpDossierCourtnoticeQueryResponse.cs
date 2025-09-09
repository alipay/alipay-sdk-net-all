using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierCourtnoticeQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierCourtnoticeQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业开庭公告返回内容
        /// </summary>
        [XmlElement("data")]
        public EpCourtNoticeDataInfo Data { get; set; }
    }
}
