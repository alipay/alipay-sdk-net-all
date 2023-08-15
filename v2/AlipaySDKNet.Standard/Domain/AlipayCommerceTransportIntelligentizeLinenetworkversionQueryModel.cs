using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeLinenetworkversionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIntelligentizeLinenetworkversionQueryModel : AopObject
    {
        /// <summary>
        /// 唯一城市代码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 公交企业ID，由公交业主/公交ISV管理
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 请求ID，唯一标识一次请求，由调用方自行确保唯一性
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
