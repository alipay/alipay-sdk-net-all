using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseEntityroleHuaweimpQueryResponse.
    /// </summary>
    public class AnttechOceanbaseEntityroleHuaweimpQueryResponse : AopResponse
    {
        /// <summary>
        /// 华为云客户名称
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }
    }
}
