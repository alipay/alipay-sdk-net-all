using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanTrendQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanTrendQueryModel : AopObject
    {
        /// <summary>
        /// 指标key，由棋盘注册，全局唯一
        /// </summary>
        [XmlElement("index_key")]
        public string IndexKey { get; set; }

        /// <summary>
        /// 请求参数，如关系类型、聚合维度
        /// </summary>
        [XmlElement("request_params")]
        public string RequestParams { get; set; }
    }
}
