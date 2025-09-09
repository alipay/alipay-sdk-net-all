using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierMemberQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierMemberQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业成员查询返回内容
        /// </summary>
        [XmlElement("data")]
        public EpMemberDataInfo Data { get; set; }
    }
}
