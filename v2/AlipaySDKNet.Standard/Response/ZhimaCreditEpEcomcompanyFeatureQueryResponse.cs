using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpEcomcompanyFeatureQueryResponse.
    /// </summary>
    public class ZhimaCreditEpEcomcompanyFeatureQueryResponse : AopResponse
    {
        /// <summary>
        /// 电商企业特征信息
        /// </summary>
        [XmlElement("data")]
        public EcomCompanyFeatureInfo Data { get; set; }
    }
}
