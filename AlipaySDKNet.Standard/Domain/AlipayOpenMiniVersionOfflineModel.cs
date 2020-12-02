using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniVersionOfflineModel : AopObject
    {
        /// <summary>
        /// 商家小程序已上架版本号。
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
