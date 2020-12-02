using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsDataDistrictQueryResponse.
    /// </summary>
    public class AlipayInsDataDistrictQueryResponse : AopResponse
    {
        /// <summary>
        /// 地区信息
        /// </summary>
        [XmlElement("districts")]
        public string Districts { get; set; }
    }
}
