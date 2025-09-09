using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpContactinfoBaseQueryResponse.
    /// </summary>
    public class ZhimaCreditEpContactinfoBaseQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业查询key（入参原样返回）
        /// </summary>
        [XmlElement("company_key")]
        public string CompanyKey { get; set; }

        /// <summary>
        /// 企业联系方式综合信息
        /// </summary>
        [XmlElement("data")]
        public EpContactComplextInfo Data { get; set; }
    }
}
