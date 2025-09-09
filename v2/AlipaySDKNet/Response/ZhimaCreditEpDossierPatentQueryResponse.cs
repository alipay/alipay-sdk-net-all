using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierPatentQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierPatentQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询专利内容
        /// </summary>
        [XmlElement("data")]
        public EpPatentDataInfo Data { get; set; }
    }
}
