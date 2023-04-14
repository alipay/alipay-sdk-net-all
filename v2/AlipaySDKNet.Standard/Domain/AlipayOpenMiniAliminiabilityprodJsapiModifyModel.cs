using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAliminiabilityprodJsapiModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAliminiabilityprodJsapiModifyModel : AopObject
    {
        /// <summary>
        /// appx最低版本
        /// </summary>
        [XmlElement("appx_min_version")]
        public string AppxMinVersion { get; set; }

        /// <summary>
        /// 来源端,高德:com.amap.app,IOT:com.alipay.iot.xpaas,微博:com.weibo.app,优酷:com.youku.app,网商银行:com.mybank.phone,菜鸟:com.cainiao.app,天猫精灵:com.alibaba.ailabs.genie.webapps,UC:com.uc.app,支付宝:com.alipay.alipaywallet,口碑:com.koubei.mobile.KoubeiClient,财富:com.alipay.antfortune,学习强国:com.xuexi.app,支付宝香港:com.alipay.wallethk,手淘:com.taobao.app
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 客户端最低版本
        /// </summary>
        [XmlElement("bundle_min_version")]
        public string BundleMinVersion { get; set; }

        /// <summary>
        /// DemoUrl
        /// </summary>
        [XmlElement("demo_url")]
        public string DemoUrl { get; set; }

        /// <summary>
        /// 英文名称
        /// </summary>
        [XmlElement("en_name")]
        public string EnName { get; set; }

        /// <summary>
        /// 交换中心接口版本
        /// </summary>
        [XmlElement("instance_version")]
        public string InstanceVersion { get; set; }

        /// <summary>
        /// 域账号
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 已发布:published,已删除:deleted
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
