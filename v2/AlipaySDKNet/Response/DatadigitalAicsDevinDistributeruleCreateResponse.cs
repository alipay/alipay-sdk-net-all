using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAicsDevinDistributeruleCreateResponse.
    /// </summary>
    public class DatadigitalAicsDevinDistributeruleCreateResponse : AopResponse
    {
        /// <summary>
        /// 新增分派规则数据ID，与 data.value 同值
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
