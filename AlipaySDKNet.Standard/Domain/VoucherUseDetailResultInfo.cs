using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherUseDetailResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUseDetailResultInfo : AopObject
    {
        /// <summary>
        /// 剩余可核销次数
        /// </summary>
        [XmlElement("voucher_max_un_use_times")]
        public long VoucherMaxUnUseTimes { get; set; }
    }
}
