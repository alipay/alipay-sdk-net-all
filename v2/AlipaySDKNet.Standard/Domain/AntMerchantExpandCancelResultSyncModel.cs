using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandCancelResultSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandCancelResultSyncModel : AopObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// AO单号
        /// </summary>
        [XmlArray("order_id")]
        [XmlArrayItem("string")]
        public List<string> OrderId { get; set; }

        /// <summary>
        /// 撤销失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
