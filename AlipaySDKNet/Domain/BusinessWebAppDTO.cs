using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessWebAppDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessWebAppDTO : AopObject
    {
        /// <summary>
        /// 测试账户
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 网站状态
        /// </summary>
        [XmlElement("app_status")]
        public string AppStatus { get; set; }

        /// <summary>
        /// 网站类型
        /// </summary>
        [XmlElement("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// 网站备注图片
        /// </summary>
        [XmlArray("ext_pictures")]
        [XmlArrayItem("string")]
        public List<string> ExtPictures { get; set; }

        /// <summary>
        /// ICP备案授权函
        /// </summary>
        [XmlElement("icp_auth_pic")]
        public string IcpAuthPic { get; set; }

        /// <summary>
        /// ICP许可证
        /// </summary>
        [XmlElement("icp_licence_pic")]
        public string IcpLicencePic { get; set; }

        /// <summary>
        /// 网站备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 测试密码
        /// </summary>
        [XmlElement("password")]
        public string Password { get; set; }

        /// <summary>
        /// 网站截图
        /// </summary>
        [XmlArray("screenshot")]
        [XmlArrayItem("string")]
        public List<string> Screenshot { get; set; }

        /// <summary>
        /// 网站地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
