using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InteOpAppInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InteOpAppInfo : AopObject
    {
        /// <summary>
        /// APP授权函图片，最小5KB，最大5M，图片格式必须为：png、bmp、gif、jpg、jpeg。 传入 alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("app_auth_pic")]
        public string AppAuthPic { get; set; }

        /// <summary>
        /// 应用下载链接。
        /// </summary>
        [XmlElement("app_download_link")]
        public string AppDownloadLink { get; set; }

        /// <summary>
        /// 应用首页截图，最小5KB，最大5M，图片格式必须为：png、bmp、gif、jpg、jpeg。传入alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("app_home_screenshot")]
        public string AppHomeScreenshot { get; set; }

        /// <summary>
        /// 商品或服务页截图，最小5KB，最大5M，图片格式必须为：png、bmp、gif、jpg、jpeg。 传入alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("app_item_screenshot")]
        public string AppItemScreenshot { get; set; }

        /// <summary>
        /// 【枚举值】 ● 苹果: 苹果 ● 应用宝: 应用宝 ● 华为: 华为 ● 360: 360 ● 小米: 小米 ● 豌豆荚: 豌豆荚 ● 其他: 其他
        /// </summary>
        [XmlArray("app_market")]
        [XmlArrayItem("string")]
        public List<string> AppMarket { get; set; }

        /// <summary>
        /// 商户的APP应用名称。
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用内支付页截图，最小5KB，最大5M，图片格式必须为：png、bmp、gif、jpg、jpeg。传入alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("app_pay_screenshot")]
        public string AppPayScreenshot { get; set; }

        /// <summary>
        /// 应用状态。 枚举值： ● 已上架: ONLINE ● 未上架: OFFLINE
        /// </summary>
        [XmlElement("app_status")]
        public string AppStatus { get; set; }

        /// <summary>
        /// 应用测试账号。
        /// </summary>
        [XmlElement("app_test_account")]
        public string AppTestAccount { get; set; }

        /// <summary>
        /// 应用测试账号密码。
        /// </summary>
        [XmlElement("app_test_account_password")]
        public string AppTestAccountPassword { get; set; }

        /// <summary>
        /// 应用类型(IOS/Android)。
        /// </summary>
        [XmlElement("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// 应用内截图，最小5KB，最大5M，图片格式必须为：png、bmp、gif、jpg、jpeg。传入 alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("in_app_screenshot")]
        public string InAppScreenshot { get; set; }
    }
}
