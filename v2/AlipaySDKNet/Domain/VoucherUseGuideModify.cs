using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherUseGuideModify Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUseGuideModify : AopObject
    {
        /// <summary>
        /// 券可用的小程序 appId，卡包详情页可跳转到该 appId。
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 指定跳转到 mini_app_id 时的具体页面路径。
        /// </summary>
        [XmlElement("mini_app_path")]
        public string MiniAppPath { get; set; }

        /// <summary>
        /// 小程序服务编码，通过 alipay.open.app.appcontent.function.create(小程序服务创建)接口创建服务后获取。
        /// </summary>
        [XmlArray("service_codes")]
        [XmlArrayItem("string")]
        public List<string> ServiceCodes { get; set; }
    }
}
