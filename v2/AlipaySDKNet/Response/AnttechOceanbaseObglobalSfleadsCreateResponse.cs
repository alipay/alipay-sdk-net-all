using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfleadsCreateResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalSfleadsCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建商机返回参数
        /// </summary>
        [XmlElement("result")]
        public SalesforceCreateLeadsResponse Result { get; set; }
    }
}
