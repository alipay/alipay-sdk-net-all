using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BoxExclusiveBase Data Structure.
    /// </summary>
    [Serializable]
    public class BoxExclusiveBase : AopObject
    {
        /// <summary>
        /// box基础工单信息
        /// </summary>
        [XmlElement("base_order_info")]
        public BoxOrderStatusInfo BaseOrderInfo { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// box描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 2020111621000215527749
        /// </summary>
        [XmlElement("main_id")]
        public string MainId { get; set; }

        /// <summary>
        /// box关联的服务类型
        /// </summary>
        [XmlElement("main_type")]
        public string MainType { get; set; }

        /// <summary>
        /// 素材类型（图片/视频）
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 素材地址
        /// </summary>
        [XmlElement("material_url")]
        public string MaterialUrl { get; set; }

        /// <summary>
        /// box关联的pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
