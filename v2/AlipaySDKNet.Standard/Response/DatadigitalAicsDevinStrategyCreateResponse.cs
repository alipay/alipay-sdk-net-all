using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAicsDevinStrategyCreateResponse.
    /// </summary>
    public class DatadigitalAicsDevinStrategyCreateResponse : AopResponse
    {
        /// <summary>
        /// 新增数据主键ID（与 data.value 同值）
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
