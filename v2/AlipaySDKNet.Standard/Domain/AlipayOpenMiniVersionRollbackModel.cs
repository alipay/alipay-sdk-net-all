using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionRollbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniVersionRollbackModel : AopObject
    {
        /// <summary>
        /// 商家小程序已上架版本。下架后将自动回滚至上一（已上架）小程序版本。 例如：商家小程序有 0.01（上一上架版本）、0.02（未上架版本）、0.03（当前上架版本） 三个版本，回滚时需传入商家小程序版本 0.03 表示将 0.03 版本回滚至上一个已上架版本即此处 0.01 版本，同时 0.03 版本将自动下架，0.01 版本自动上架（无需审核）。
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序客户端类型，默认为支付宝端。常见支持如下客户端： com.alipay.alipaywallet：支付宝端； com.alibaba.android.rimet：DINGDING端； com.amap.app：高德端； com.alibaba.ailabs.genie.webapps：天猫精灵端； com.alipay.iot.xpaas：支付宝IoT端。 如需更多端投放，请联系业务BD。
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }
    }
}
