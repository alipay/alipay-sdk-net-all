using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodPoamountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodPoamountQueryModel : AopObject
    {
        /// <summary>
        /// PO号
        /// </summary>
        [XmlElement("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 供应商蚂蚁2088账号PID
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }
    }
}
