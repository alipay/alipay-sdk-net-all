using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantApplyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantApplyInfo : AopObject
    {
        /// <summary>
        /// 安心付商户入驻申请人
        /// </summary>
        [XmlElement("applier")]
        public string Applier { get; set; }

        /// <summary>
        /// 安心付商户入驻申请单
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 申请明细
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("merchant_apply_item_info")]
        public List<MerchantApplyItemInfo> ItemInfos { get; set; }

        /// <summary>
        /// 履约明细
        /// </summary>
        [XmlArray("perform_record_infos")]
        [XmlArrayItem("merchant_apply_perform_record_info")]
        public List<MerchantApplyPerformRecordInfo> PerformRecordInfos { get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
