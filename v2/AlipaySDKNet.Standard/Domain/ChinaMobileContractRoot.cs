using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChinaMobileContractRoot Data Structure.
    /// </summary>
    [Serializable]
    public class ChinaMobileContractRoot : AopObject
    {
        /// <summary>
        /// 移动核销参数Body
        /// </summary>
        [XmlElement("body")]
        public ChinaMobileBody Body { get; set; }

        /// <summary>
        /// 移动核销接口Head
        /// </summary>
        [XmlElement("head")]
        public ChinaMobileHead Head { get; set; }

        /// <summary>
        /// 支付宝券核销信息
        /// </summary>
        [XmlElement("voucher")]
        public ChinaMobileVoucher Voucher { get; set; }
    }
}
