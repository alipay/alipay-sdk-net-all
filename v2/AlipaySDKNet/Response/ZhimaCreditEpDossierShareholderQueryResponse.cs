using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierShareholderQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierShareholderQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业股东信息查询
        /// </summary>
        [XmlElement("data")]
        public EpShareHolderDataInfo Data { get; set; }
    }
}
