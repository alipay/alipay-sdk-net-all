using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FxiaokeUpdateLeadsRequest Data Structure.
    /// </summary>
    [Serializable]
    public class FxiaokeUpdateLeadsRequest : AopObject
    {
        /// <summary>
        /// 负责BD工号
        /// </summary>
        [XmlElement("bd_work_no")]
        public string BdWorkNo { get; set; }

        /// <summary>
        /// 商机编码
        /// </summary>
        [XmlElement("leads_code")]
        public string LeadsCode { get; set; }

        /// <summary>
        /// 商机来源伙伴pid - 报备伙伴
        /// </summary>
        [XmlElement("leads_source_partner_id")]
        public string LeadsSourcePartnerId { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("modifier")]
        public string Modifier { get; set; }
    }
}
