using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCrossborderEcomcompanydetailQueryResponse.
    /// </summary>
    public class ZhimaCreditEpCrossborderEcomcompanydetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果集
        /// </summary>
        [XmlElement("data")]
        public CrossBorderEcomCompanyDetail Data { get; set; }
    }
}
