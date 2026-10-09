using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayPosterAppQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayPosterAppQueryModel : AopObject
    {
        /// <summary>
        /// 设备业务标识，调用方须有该设备的查询权限
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 业务标识；当前立减进度条刷新逻辑不使用此字段
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 交互类型，仅支持refresh
        /// </summary>
        [XmlElement("interaction_type")]
        public string InteractionType { get; set; }

        /// <summary>
        /// 设备机具型号对应的素材匹配标识，须与biz_tid对应的设备一致
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 海报类型，仅支持REDUCE_PROCESS_POSTER
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 小程序或渲染程序版本号，例如1.1
        /// </summary>
        [XmlElement("program_version")]
        public string ProgramVersion { get; set; }

        /// <summary>
        /// 海报计划ID，须属于指定设备
        /// </summary>
        [XmlElement("schema_id")]
        public string SchemaId { get; set; }

        /// <summary>
        /// 缓存模式开关；当前立减进度条刷新路径不使用此值
        /// </summary>
        [XmlElement("use_cache")]
        public bool UseCache { get; set; }
    }
}
