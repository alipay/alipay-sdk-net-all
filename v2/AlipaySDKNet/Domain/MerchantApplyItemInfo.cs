using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantApplyItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantApplyItemInfo : AopObject
    {
        /// <summary>
        /// 申请单编号
        /// </summary>
        [XmlElement("apply_order_id")]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 申请结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 申请类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
