using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RetryDataItem Data Structure.
    /// </summary>
    [Serializable]
    public class RetryDataItem : AopObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务消息
        /// </summary>
        [XmlArray("biz_messages")]
        [XmlArrayItem("string")]
        public List<string> BizMessages { get; set; }
    }
}
