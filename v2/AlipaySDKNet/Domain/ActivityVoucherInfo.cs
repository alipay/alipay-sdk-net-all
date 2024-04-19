using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityVoucherInfo : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动状态： 草稿(INIT),已提交审核(P_AUDIT),已审核(AUDIT),待激活(WAIT_ACTIVE),激活(ACTIVE),暂停(PAUSE),已结束(FINISHED),已废弃(DISCARD)
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 商户logo
        /// </summary>
        [XmlElement("merchant_logo")]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 券列表
        /// </summary>
        [XmlArray("voucher_list")]
        [XmlArrayItem("voucher_item")]
        public List<VoucherItem> VoucherList { get; set; }
    }
}
