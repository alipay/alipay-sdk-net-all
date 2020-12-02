using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionGrayCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniVersionGrayCancelModel : AopObject
    {
        /// <summary>
        /// 商家灰度中的小程序版本号，结束灰度后小程序将回到审核通过状态。
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
