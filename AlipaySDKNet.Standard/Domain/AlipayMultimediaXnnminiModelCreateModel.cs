using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMultimediaXnnminiModelCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMultimediaXnnminiModelCreateModel : AopObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 模型描述
        /// </summary>
        [XmlElement("des")]
        public string Des { get; set; }

        /// <summary>
        /// 模型校验参数信息
        /// </summary>
        [XmlElement("license")]
        public string License { get; set; }

        /// <summary>
        /// 模型绑定应用id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 模型原始链接地址
        /// </summary>
        [XmlElement("ori_url")]
        public string OriUrl { get; set; }

        /// <summary>
        /// 模型类型：XNN、TF_JS
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 模型创建用户
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 版本信息标识id
        /// </summary>
        [XmlElement("version_id")]
        public string VersionId { get; set; }
    }
}
