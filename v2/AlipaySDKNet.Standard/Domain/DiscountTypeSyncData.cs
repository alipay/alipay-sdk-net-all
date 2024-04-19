using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiscountTypeSyncData Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountTypeSyncData : AopObject
    {
        /// <summary>
        /// 商户回传的优惠金额，如用户享受的红包金额，单位元
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 商户数据回传的优惠信息的名称。
        /// </summary>
        [XmlElement("discount_desc")]
        public string DiscountDesc { get; set; }
    }
}
