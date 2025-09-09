using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierBackgroundQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierBackgroundQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("data")]
        public ZmepDossierBackgroundDataInfo Data { get; set; }
    }
}
