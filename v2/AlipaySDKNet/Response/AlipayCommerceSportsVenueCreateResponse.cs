using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceSportsVenueCreateResponse.
    /// </summary>
    public class AlipayCommerceSportsVenueCreateResponse : AopResponse
    {
        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 服务商对应的场馆ID
        /// </summary>
        [XmlElement("out_venue_id")]
        public string OutVenueId { get; set; }

        /// <summary>
        /// 子场馆信息
        /// </summary>
        [XmlArray("sub_venue_list")]
        [XmlArrayItem("sub_venue_audit_status")]
        public List<SubVenueAuditStatus> SubVenueList { get; set; }

        /// <summary>
        /// 支付宝对应的场馆ID
        /// </summary>
        [XmlElement("venue_id")]
        public string VenueId { get; set; }

        /// <summary>
        /// 场馆当前状态 安全审核中：infosec-audit 安全审核不通过：infosec-unpass 云验收中： cloud-audit 云验收不通过： cloud-unpass 上架： online 下架： offline 人工下架： manual-offline
        /// </summary>
        [XmlElement("venue_status")]
        public string VenueStatus { get; set; }
    }
}
