using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableAppInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableAppInfo : AopObject
    {
        /// <summary>
        /// 可核销的支付宝小程序id
        /// </summary>
        [XmlArray("available_app_ids")]
        [XmlArrayItem("string")]
        public List<string> AvailableAppIds { get; set; }
    }
}
