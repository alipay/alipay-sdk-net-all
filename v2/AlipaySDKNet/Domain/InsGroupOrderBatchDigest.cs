using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsGroupOrderBatchDigest Data Structure.
    /// </summary>
    [Serializable]
    public class InsGroupOrderBatchDigest : AopObject
    {
        /// <summary>
        /// 批次单号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
