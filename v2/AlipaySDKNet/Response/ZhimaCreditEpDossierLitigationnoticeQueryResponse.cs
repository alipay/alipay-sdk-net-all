using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierLitigationnoticeQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierLitigationnoticeQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业涉诉公告内容
        /// </summary>
        [XmlElement("data")]
        public EpLitigationNoticeDataInfo Data { get; set; }
    }
}
