using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantApplyPerformRecordInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantApplyPerformRecordInfo : AopObject
    {
        /// <summary>
        /// 申请单
        /// </summary>
        [XmlElement("apply_order_id")]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 主键id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 如果失败则是失败原因
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 履约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
