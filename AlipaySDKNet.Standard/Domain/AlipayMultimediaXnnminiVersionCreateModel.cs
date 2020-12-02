using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMultimediaXnnminiVersionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMultimediaXnnminiVersionCreateModel : AopObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 版本描述
        /// </summary>
        [XmlElement("des")]
        public string Des { get; set; }

        /// <summary>
        /// 模型绑定应用id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 模型版本号
        /// </summary>
        [XmlElement("model_version")]
        public string ModelVersion { get; set; }

        /// <summary>
        /// 模型创建用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
