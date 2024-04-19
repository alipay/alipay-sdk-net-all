using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppJfInstcodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppJfInstcodeQueryModel : AopObject
    {
        /// <summary>
        /// 城市级别的行政区划代码, 支持地市以及区县 杭州: 330100
        /// </summary>
        [XmlElement("ad_code")]
        public string AdCode { get; set; }

        /// <summary>
        /// 业务类型, 默认JF
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 支付宝提供的渠道短码
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 用于指定对应的服务类型
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 缴费费种
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
