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

        /// <summary>
        /// 查得标记
        /// </summary>
        [XmlElement("data_found")]
        public bool DataFound { get; set; }
    }
}
