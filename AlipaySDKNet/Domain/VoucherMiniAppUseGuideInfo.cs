using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherMiniAppUseGuideInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherMiniAppUseGuideInfo : AopObject
    {
        /// <summary>
        /// 小程序服务编码，通过 alipay.open.app.appcontent.function.create(小程序服务创建)接口创建服务后获取。 限制: 1.只有mini_app_id有值时该值传入才会有效 2.当前只支持一个服务code 3.service_codes与mini_app_path只能且必须二选一
        /// </summary>
        [XmlArray("mini_app_service_codes")]
        [XmlArrayItem("string")]
        public List<string> MiniAppServiceCodes { get; set; }

        /// <summary>
        /// 指定跳转到mini_app_id时的具体页面路径。 限制： 1、只有mini_app_id有值时该值传入才会有效 2、该小程序路径是相对路径。详情参考小程序scheme链接介绍https://opendocs.alipay.com/support/01rb18。 3.service_codes与mini_app_path只能二选一或者都不填写。
        /// </summary>
        [XmlElement("mini_app_url")]
        public string MiniAppUrl { get; set; }
    }
}
