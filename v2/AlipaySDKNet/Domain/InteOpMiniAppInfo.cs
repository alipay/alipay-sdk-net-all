using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InteOpMiniAppInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InteOpMiniAppInfo : AopObject
    {
        /// <summary>
        /// 被签约商家下任意小程序APPID ID编号。
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序名称。
        /// </summary>
        [XmlElement("mini_app_name")]
        public string MiniAppName { get; set; }

        /// <summary>
        /// 上传商家小程序截图信息，最小5KB ，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg。传入 alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("mini_app_screenshot")]
        public string MiniAppScreenshot { get; set; }
    }
}
