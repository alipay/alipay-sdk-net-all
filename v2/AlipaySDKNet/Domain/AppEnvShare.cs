using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppEnvShare Data Structure.
    /// </summary>
    [Serializable]
    public class AppEnvShare : AopObject
    {
        /// <summary>
        /// 应用类型为普通小程序
        /// </summary>
        [XmlElement("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// 环境信息描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 环境的id
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 序列值
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 表示这条资源复用关联关系来自云托管
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 资源复用关联应用ID
        /// </summary>
        [XmlElement("share_app_id")]
        public string ShareAppId { get; set; }

        /// <summary>
        /// 应用环境状态值，1表示资源复用应用环境
        /// </summary>
        [XmlElement("state")]
        public long State { get; set; }
    }
}
