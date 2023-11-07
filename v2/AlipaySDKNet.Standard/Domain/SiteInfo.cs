using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SiteInfo : AopObject
    {
        /// <summary>
        /// 测试账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 授权函照片
        /// </summary>
        [XmlElement("auth_letter_image")]
        public string AuthLetterImage { get; set; }

        /// <summary>
        /// 下载地址
        /// </summary>
        [XmlElement("download")]
        public string Download { get; set; }

        /// <summary>
        /// ICP备案/许可证号
        /// </summary>
        [XmlElement("icp_no")]
        public string IcpNo { get; set; }

        /// <summary>
        /// ICP备案主体主办单位名称
        /// </summary>
        [XmlElement("icp_org_name")]
        public string IcpOrgName { get; set; }

        /// <summary>
        /// ICP备案主体信息服务名称
        /// </summary>
        [XmlElement("icp_service_name")]
        public string IcpServiceName { get; set; }

        /// <summary>
        /// 应用市场
        /// </summary>
        [XmlElement("market")]
        public string Market { get; set; }

        /// <summary>
        /// 测试密码
        /// </summary>
        [XmlElement("password")]
        public string Password { get; set; }

        /// <summary>
        /// 备注说明
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 备注说明图片
        /// </summary>
        [XmlElement("remark_image")]
        public string RemarkImage { get; set; }

        /// <summary>
        /// 截图照片；当传入交易场景trade_scene，且当传入trade_scene=WAP、trade_scene=APP、trade_scene=PC时该参数必传
        /// </summary>
        [XmlElement("screenshot_image")]
        public string ScreenshotImage { get; set; }

        /// <summary>
        /// 网站域名
        /// </summary>
        [XmlElement("site_domain")]
        public string SiteDomain { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("site_name")]
        public string SiteName { get; set; }

        /// <summary>
        /// 网站：01  APP  : 02  服务窗:03  公众号:04  其他:05  支付宝小程序:06
        /// </summary>
        [XmlElement("site_type")]
        public string SiteType { get; set; }

        /// <summary>
        /// 站点地址
        /// </summary>
        [XmlElement("site_url")]
        public string SiteUrl { get; set; }

        /// <summary>
        /// 上架状态；
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 小程序appId; 当传入service，且包含jsapi支付时，sites的site_type=06, tiny_app_id必填。
        /// </summary>
        [XmlElement("tiny_app_id")]
        public string TinyAppId { get; set; }
    }
}
