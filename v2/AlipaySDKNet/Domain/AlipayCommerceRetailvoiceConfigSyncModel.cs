using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailvoiceConfigSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailvoiceConfigSyncModel : AopObject
    {
        /// <summary>
        /// 广告主名称
        /// </summary>
        [XmlElement("advertiser_name")]
        public string AdvertiserName { get; set; }

        /// <summary>
        /// 投放结束时间
        /// </summary>
        [XmlElement("delivery_end_time")]
        public string DeliveryEndTime { get; set; }

        /// <summary>
        /// 投放开始时间
        /// </summary>
        [XmlElement("delivery_start_time")]
        public string DeliveryStartTime { get; set; }

        /// <summary>
        /// SN数量(对账基准)
        /// </summary>
        [XmlElement("expected_sn_count")]
        public long ExpectedSnCount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("material_ids")]
        [XmlArrayItem("string")]
        public List<string> MaterialIds { get; set; }

        /// <summary>
        /// AFTS文件ID
        /// </summary>
        [XmlElement("scope_file_id")]
        public string ScopeFileId { get; set; }

        /// <summary>
        /// 范围类型(DEVICE_SN)
        /// </summary>
        [XmlElement("scope_type")]
        public string ScopeType { get; set; }

        /// <summary>
        /// 触享业务主键(幂等键1)
        /// </summary>
        [XmlElement("source_task_id")]
        public string SourceTaskId { get; set; }

        /// <summary>
        /// 触享版本号(幂等键2)
        /// </summary>
        [XmlElement("source_version")]
        public string SourceVersion { get; set; }

        /// <summary>
        /// 模板类型(LINKAGE_VOICE)
        /// </summary>
        [XmlElement("template_type")]
        public string TemplateType { get; set; }

        /// <summary>
        /// 触点类型ALL/BEFORE/AFTER
        /// </summary>
        [XmlElement("touchpoint_type")]
        public string TouchpointType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("voice_content_list")]
        [XmlArrayItem("voice_content")]
        public List<VoiceContent> VoiceContentList { get; set; }
    }
}
