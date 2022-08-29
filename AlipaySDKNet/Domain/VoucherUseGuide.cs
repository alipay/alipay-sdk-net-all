using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherUseGuide Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUseGuide : AopObject
    {
        /// <summary>
        /// 券可用的小程序appId，卡包详情页可跳转到该appId
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 指定跳转到mini_app_id时的具体页面路径。
        /// </summary>
        [XmlElement("mini_app_path")]
        public string MiniAppPath { get; set; }

        /// <summary>
        /// 小程序核销。
        /// </summary>
        [XmlElement("mini_app_use_guide")]
        public bool MiniAppUseGuide { get; set; }

        /// <summary>
        /// 线下扫码核销。
        /// </summary>
        [XmlElement("offline_code_use_guide")]
        public bool OfflineCodeUseGuide { get; set; }

        /// <summary>
        /// 小程序服务编码，通过 alipay.open.app.appcontent.function.create(小程序服务创建)接口创建服务后获取。
        /// </summary>
        [XmlArray("service_codes")]
        [XmlArrayItem("string")]
        public List<string> ServiceCodes { get; set; }
    }
}
