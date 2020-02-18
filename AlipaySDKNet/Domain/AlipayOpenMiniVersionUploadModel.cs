using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniVersionUploadModel : AopObject
    {
        /// <summary>
        /// 小程序版本号，版本号必须满足 x.y.z, 且均为数字。要求版本号比商户之前最新的版本号高。
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序投放的端参数，例如投放到支付宝钱包是支付宝端。该参数可选，默认支付宝端 ，目前仅支持支付宝端，枚举列举：com.alipay.alipaywallet:支付宝端
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 模板的配置参数
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板版本号，版本号必须满足 x.y.z, 且均为数字。不传默认使用最新在架模板版本。
        /// </summary>
        [XmlElement("template_version")]
        public string TemplateVersion { get; set; }
    }
}
