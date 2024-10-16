using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpSpuinfoGeneralQueryResponse.
    /// </summary>
    public class ZhimaCreditEpSpuinfoGeneralQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业查询key
        /// </summary>
        [XmlElement("company_key")]
        public string CompanyKey { get; set; }

        /// <summary>
        /// 结果集
        /// </summary>
        [XmlElement("data")]
        public EpSpuGeneralInfoResult Data { get; set; }
    }
}
