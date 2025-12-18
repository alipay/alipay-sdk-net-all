using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetEcoIotOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetEcoIotOrderInfo : AopObject
    {
        /// <summary>
        /// 申请日期
        /// </summary>
        [XmlElement("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 申请单ID
        /// </summary>
        [XmlElement("apply_order_id")]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 首次绑定日期
        /// </summary>
        [XmlElement("first_bind_date")]
        public string FirstBindDate { get; set; }

        /// <summary>
        /// 是否激活 1已激活，0未激活，2超时未激活终态
        /// </summary>
        [XmlElement("is_active")]
        public string IsActive { get; set; }

        /// <summary>
        /// 是否可返佣 1是，0否，2超时不可返佣终态
        /// </summary>
        [XmlElement("is_rebate_eligible")]
        public string IsRebateEligible { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// sn码
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
