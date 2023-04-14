using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringBizMovehomeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringBizMovehomeSyncModel : AopObject
    {
        /// <summary>
        /// leads信息列表
        /// </summary>
        [XmlArray("leads_info_list")]
        [XmlArrayItem("kcp_leads_info")]
        public List<KcpLeadsInfo> LeadsInfoList { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
