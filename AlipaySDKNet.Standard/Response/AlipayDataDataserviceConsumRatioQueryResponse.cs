using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceConsumRatioQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceConsumRatioQueryResponse : AopResponse
    {
        /// <summary>
        /// 占比数据接口返回数据结构
        /// </summary>
        [XmlElement("ratio_detail")]
        public RatioDetail RatioDetail { get; set; }
    }
}
