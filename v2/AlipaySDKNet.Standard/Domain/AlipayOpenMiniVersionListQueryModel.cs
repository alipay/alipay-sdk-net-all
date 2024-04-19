using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniVersionListQueryModel : AopObject
    {
        /// <summary>
        /// 端参数，用于查询多端版本，不传默认为支付宝端。。常见支持如下客户端： com.alipay.alipaywallet：支付宝端； com.alibaba.android.rimet：DINGDING端； com.amap.app：高德端； com.alibaba.ailabs.genie.webapps：天猫精灵端； com.alipay.iot.xpaas：支付宝IoT端。 如需更多端投放，请联系业务BD。
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 版本状态列表，用英文逗号","分割，可选；不填默认不返回。
        /// </summary>
        [XmlElement("version_status")]
        public string VersionStatus { get; set; }
    }
}
