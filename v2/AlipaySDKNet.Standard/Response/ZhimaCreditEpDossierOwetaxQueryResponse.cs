using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierOwetaxQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierOwetaxQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询数据结果
        /// </summary>
        [XmlElement("data")]
        public EpOweTaxDataInfo Data { get; set; }
    }
}
