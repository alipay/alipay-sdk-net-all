using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionAuditCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniVersionAuditCancelModel : AopObject
    {
        /// <summary>
        /// 商家小程序审核中的版本号, 不传默认撤消正在审核中的版本。
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序投放的端参数，例如投放到支付宝钱包是支付宝端。默认支付宝端。支持： com.alipay.alipaywallet:支付宝端； com.alipay.iot.xpaas：支付宝IoT端。
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }
    }
}
