using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitQueryComponent Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitQueryComponent : AopObject
    {
        /// <summary>
        /// 渠道标识，用于判断渠道过滤规则。非固定值，由业务运营定义
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 地理位置纬度，单位：度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 地理位置经度，单位：度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 是否跳过发奖流水中的券信息补充，默认不跳过
        /// </summary>
        [XmlElement("skip_voucher_info")]
        public bool SkipVoucherInfo { get; set; }

        /// <summary>
        /// 权益来源标识，非固定值，由业务运营定义
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
