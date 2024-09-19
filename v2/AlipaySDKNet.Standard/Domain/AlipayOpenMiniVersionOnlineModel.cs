using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniVersionOnlineModel : AopObject
    {
        /// <summary>
        /// 商家小程序版本号，需为审核通过状态或灰度中版本。
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序客户端类型，默认为支付宝端。常见支持如下客户端： com.alipay.alipaywallet：支付宝端； com.alibaba.android.rimet：DINGDING端； com.amap.app：高德端； com.alibaba.ailabs.genie.webapps：天猫精灵端； com.alipay.iot.xpaas：支付宝IoT端。 如需更多端投放，请联系业务BD。
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// true - 性能优先； false - 覆盖优先（默认）
        /// </summary>
        [XmlElement("downgrade")]
        public bool Downgrade { get; set; }

        /// <summary>
        /// 如果该字段为true，在首次发版的小程序在备案未完成的情况下，允许小程序上架，但小程序上架后只可以上架可扫码进行使用，但不可被搜索、限制访问人数（50人/每天）、限制公域（无法进行商品、服务、营促销）、限制上架后90天不完成备案自动下架。 默认为false
        /// </summary>
        [XmlElement("permit_registration_limit_release")]
        public bool PermitRegistrationLimitRelease { get; set; }
    }
}
