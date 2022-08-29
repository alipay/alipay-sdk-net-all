using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherInventoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherInventoryInfo : AopObject
    {
        /// <summary>
        /// 已发放数量。
        /// </summary>
        [XmlElement("send_count")]
        public long SendCount { get; set; }

        /// <summary>
        /// 已核销数量。
        /// </summary>
        [XmlElement("use_count")]
        public long UseCount { get; set; }
    }
}
