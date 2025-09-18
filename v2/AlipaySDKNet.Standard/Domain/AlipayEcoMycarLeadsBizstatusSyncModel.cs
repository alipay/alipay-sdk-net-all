using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarLeadsBizstatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarLeadsBizstatusSyncModel : AopObject
    {
        /// <summary>
        /// 已到店，支付宝方统一分配
        /// </summary>
        [XmlElement("leads_biz_code")]
        public string LeadsBizCode { get; set; }

        /// <summary>
        /// 线索id（当source_channel和scene_code为空时必选，有线索id时优先通过线索id唯一定位线索）
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 线索场景码（当leads_id为空时必选）
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 线索渠道（当leads_id为空时必选）
        /// </summary>
        [XmlElement("source_channel")]
        public string SourceChannel { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
