using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableAccountInfo : AopObject
    {
        /// <summary>
        /// 优惠券可核销的直连商户PID
        /// </summary>
        [XmlArray("available_pids")]
        [XmlArrayItem("string")]
        public List<string> AvailablePids { get; set; }

        /// <summary>
        /// 优惠券可核销的间连商户SMID
        /// </summary>
        [XmlArray("available_smids")]
        [XmlArrayItem("string")]
        public List<string> AvailableSmids { get; set; }
    }
}
