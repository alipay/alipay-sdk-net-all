using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InteOpWebSiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InteOpWebSiteInfo : AopObject
    {
        /// <summary>
        /// 网站首页截图，最小5KB，最大5M，图片格式必须为：png、bmp、gif、jpg、jpeg。传入alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("web_home_screenshot")]
        public string WebHomeScreenshot { get; set; }

        /// <summary>
        /// 网站商品页截图，最小5KB，最大5M，图片格式必须为：png、bmp、gif、jpg、jpeg。传入 alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("web_item_screenshot")]
        public string WebItemScreenshot { get; set; }

        /// <summary>
        /// 网站支付页截图，最小5KB，最大5M，图片格式必须为：png、bmp、gif、jpg、jpeg。传入alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("web_pay_screenshot")]
        public string WebPayScreenshot { get; set; }

        /// <summary>
        /// 接入网址信息。
        /// </summary>
        [XmlElement("web_sites")]
        public string WebSites { get; set; }

        /// <summary>
        /// 接入网址的授权涵，格式为.doc .docx .pdf格式。传入alipay.open.file.upload接口上传获取的file_id。
        /// </summary>
        [XmlElement("web_sites_loa")]
        public string WebSitesLoa { get; set; }

        /// <summary>
        /// 网站状态
        /// </summary>
        [XmlElement("web_status")]
        public string WebStatus { get; set; }

        /// <summary>
        /// 网站测试账号。
        /// </summary>
        [XmlElement("web_test_account")]
        public string WebTestAccount { get; set; }

        /// <summary>
        /// 可以登录网站的测试账户的密码
        /// </summary>
        [XmlElement("web_test_account_password")]
        public string WebTestAccountPassword { get; set; }
    }
}
