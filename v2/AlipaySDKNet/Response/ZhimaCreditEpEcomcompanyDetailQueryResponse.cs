using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpEcomcompanyDetailQueryResponse.
    /// </summary>
    public class ZhimaCreditEpEcomcompanyDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 电商企业明细数据
        /// </summary>
        [XmlElement("data")]
        public EcomCompanyInfo Data { get; set; }
    }
}
