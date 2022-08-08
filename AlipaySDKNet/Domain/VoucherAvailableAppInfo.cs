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
        /// 可核销的支付宝小程序id 限制： 1、必须是支付宝小程序 2、如果包含重复的小程序id会自动进行去重操作。
        /// </summary>
        [XmlArray("available_app_ids")]
        [XmlArrayItem("string")]
        public List<string> AvailableAppIds { get; set; }
    }
}
