using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAicsDevinStrategyPageQueryResponse.
    /// </summary>
    public class DatadigitalAicsDevinStrategyPageQueryResponse : AopResponse
    {
        /// <summary>
        /// 策略列表分页结果与页结构
        /// </summary>
        [XmlElement("data")]
        public StrategyPageQueryData Data { get; set; }
    }
}
