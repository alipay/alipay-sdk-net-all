using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierBranchQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierBranchQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业分支机构返回内容
        /// </summary>
        [XmlElement("data")]
        public EpBranchDataInfo Data { get; set; }
    }
}
