using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JsApiBaseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class JsApiBaseDTO : AopObject
    {
        /// <summary>
        /// Appx最低版本
        /// </summary>
        [XmlElement("appx_min_version")]
        public string AppxMinVersion { get; set; }

        /// <summary>
        /// 来源端,高德:com.amap.app,IOT:com.alipay.iot.xpaas,微博:com.weibo.app,优酷:com.youku.app,网商银行:com.mybank.phone,菜鸟:com.cainiao.app,天猫精灵:com.alibaba.ailabs.genie.webapps,UC:com.uc.app,支付宝:com.alipay.alipaywallet,口碑:com.koubei.mobile.KoubeiClient,财富:com.alipay.antfortune,学习强国:com.xuexi.app,支付宝香港:com.alipay.wallethk
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 客户端最低版本
        /// </summary>
        [XmlElement("bundle_min_version")]
        public string BundleMinVersion { get; set; }

        /// <summary>
        /// 中文名称
        /// </summary>
        [XmlElement("cn_name")]
        public string CnName { get; set; }

        /// <summary>
        /// DemoURL
        /// </summary>
        [XmlElement("demo_url")]
        public string DemoUrl { get; set; }

        /// <summary>
        /// 接口描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 英文名称
        /// </summary>
        [XmlElement("en_name")]
        public string EnName { get; set; }

        /// <summary>
        /// 是否是基础类型，是:true,否:false
        /// </summary>
        [XmlElement("general")]
        public bool General { get; set; }

        /// <summary>
        /// 是否异步,异步：true,同步:false
        /// </summary>
        [XmlElement("is_async")]
        public bool IsAsync { get; set; }

        /// <summary>
        /// JSAPI版本
        /// </summary>
        [XmlElement("jsapi_version")]
        public string JsapiVersion { get; set; }

        /// <summary>
        /// private：私有；public：公开；value_add：增值
        /// </summary>
        [XmlElement("open_range")]
        public string OpenRange { get; set; }

        /// <summary>
        /// 负责人域账号
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 示例代码
        /// </summary>
        [XmlElement("sample_code")]
        public string SampleCode { get; set; }
    }
}
