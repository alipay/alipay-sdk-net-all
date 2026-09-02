using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarAutohomeleadsStatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarAutohomeleadsStatusSyncModel : AopObject
    {
        /// <summary>
        /// 线索接通状态明细
        /// </summary>
        [XmlElement("contact_status")]
        public AutohomeContactStatusModel ContactStatus { get; set; }

        /// <summary>
        /// 线索购车状态明细
        /// </summary>
        [XmlElement("deal_status")]
        public AutohomeDealStatusModel DealStatus { get; set; }

        /// <summary>
        /// 线索入库状态明细
        /// </summary>
        [XmlElement("distribute_status")]
        public AutohomeDistributeStatusModel DistributeStatus { get; set; }

        /// <summary>
        /// 汽车之家线索上报线索管理平台生成的唯一ID
        /// </summary>
        [XmlElement("key_push_id")]
        public string KeyPushId { get; set; }

        /// <summary>
        /// 线索拆分后生成的唯一ID
        /// </summary>
        [XmlElement("key_split_id")]
        public string KeySplitId { get; set; }

        /// <summary>
        /// 线索入线索数仓库后生成的唯一ID，当线索预留时此字段为空
        /// </summary>
        [XmlElement("key_unique_id")]
        public string KeyUniqueId { get; set; }

        /// <summary>
        /// 汽车之家线索后效状态类型
        /// </summary>
        [XmlElement("status_type")]
        public string StatusType { get; set; }
    }
}
