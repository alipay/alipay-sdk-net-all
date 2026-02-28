using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InteOpHtmlFiveInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InteOpHtmlFiveInfo : AopObject
    {
        /// <summary>
        /// 网站备注图片，最小5KB ，最大5M。图片格式必须为：png、bmp、gif、jpg、jpeg。传入alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("h_5_extra_pic")]
        public string H5ExtraPic { get; set; }

        /// <summary>
        /// H5首页截图，最小5KB ，最大5M。图片格式必须为：png、bmp、gif、jpg、jpeg。传入alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("h_5_home_screenshot")]
        public string H5HomeScreenshot { get; set; }

        /// <summary>
        /// H5商品页截图，最小5KB ，最大5M。图片格式必须为：png、bmp、gif、jpg、jpeg。传入alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("h_5_item_screenshot")]
        public string H5ItemScreenshot { get; set; }

        /// <summary>
        /// 网站信息文本。
        /// </summary>
        [XmlElement("h_5_memo")]
        public string H5Memo { get; set; }

        /// <summary>
        /// H5支付页截图，最小5KB ，最大5M。图片格式必须为：png、bmp、gif、jpg、jpeg。传入alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("h_5_pay_screenshot")]
        public string H5PayScreenshot { get; set; }

        /// <summary>
        /// H5网站地址。
        /// </summary>
        [XmlElement("h_5_sites")]
        public string H5Sites { get; set; }

        /// <summary>
        /// H5网址授权函，最小5KB ，最大5M。图片格式必须为：png、bmp、gif、jpg、jpeg。传入alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("h_5_sites_loa")]
        public string H5SitesLoa { get; set; }

        /// <summary>
        /// H5网站状态
        /// </summary>
        [XmlElement("h_5_status")]
        public string H5Status { get; set; }

        /// <summary>
        /// H5网站测试账户
        /// </summary>
        [XmlElement("h_5_test_account")]
        public string H5TestAccount { get; set; }

        /// <summary>
        /// H5网站测试账户密码
        /// </summary>
        [XmlElement("h_5_test_account_password")]
        public string H5TestAccountPassword { get; set; }
    }
}
