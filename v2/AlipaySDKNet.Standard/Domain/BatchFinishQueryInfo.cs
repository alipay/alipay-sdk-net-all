using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BatchFinishQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BatchFinishQueryInfo : AopObject
    {
        /// <summary>
        /// 支付宝侧结算批次id,全局唯一
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }
    }
}
