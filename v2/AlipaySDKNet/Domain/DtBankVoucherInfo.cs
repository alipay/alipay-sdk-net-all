using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankVoucherInfo : AopObject
    {
        /// <summary>
        /// 红包有效时间
        /// </summary>
        [XmlElement("coupon_available_time")]
        public DtBankCouponAvailableTime CouponAvailableTime { get; set; }

        /// <summary>
        /// 红包使用说明文案
        /// </summary>
        [XmlArray("coupon_instruction_list")]
        [XmlArrayItem("string")]
        public List<string> CouponInstructionList { get; set; }
    }
}
