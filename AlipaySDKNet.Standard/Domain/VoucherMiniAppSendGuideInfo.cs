using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherMiniAppSendGuideInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherMiniAppSendGuideInfo : AopObject
    {
        /// <summary>
        /// 指定跳转到mini_app_id时的具体页面路径。 限制： 1、只有mini_app_id有值时该值传入才会有效 2、该小程序路径是相对路径。详情参考小程序scheme链接介绍https://opendocs.alipay.com/support/01rb18。 3.service_codes与mini_app_path只能二选一或者都不填写。
        /// </summary>
        [XmlElement("mini_app_url")]
        public string MiniAppUrl { get; set; }
    }
}
