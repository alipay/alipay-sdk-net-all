using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingUsercertificateBatchqueryResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingUsercertificateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 数据列表
        /// </summary>
        [XmlElement("list")]
        public UsercertificateObject List { get; set; }

        /// <summary>
        /// 证书总个数
        /// </summary>
        [XmlElement("total")]
        public string Total { get; set; }
    }
}
