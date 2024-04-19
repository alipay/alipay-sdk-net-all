using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseLayerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseLayerQueryModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 是否逆序
        /// </summary>
        [XmlElement("desc")]
        public bool Desc { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 层名称
        /// </summary>
        [XmlElement("layer_name")]
        public string LayerName { get; set; }

        /// <summary>
        /// 层名称模糊查询
        /// </summary>
        [XmlElement("layer_name_like")]
        public string LayerNameLike { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页显示条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
