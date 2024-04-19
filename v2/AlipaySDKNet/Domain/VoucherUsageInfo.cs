using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherUsageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUsageInfo : AopObject
    {
        /// <summary>
        /// 点击优惠券「去使用」按钮，可以使用优惠券的地址。一般为小程序页面地址。
        /// </summary>
        [XmlElement("goto_use_url")]
        public string GotoUseUrl { get; set; }

        /// <summary>
        /// 优惠券使用记录的跳转地址
        /// </summary>
        [XmlElement("use_record_url")]
        public string UseRecordUrl { get; set; }
    }
}
