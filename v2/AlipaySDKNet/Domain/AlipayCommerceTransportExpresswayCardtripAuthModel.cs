using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportExpresswayCardtripAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportExpresswayCardtripAuthModel : AopObject
    {
        /// <summary>
        /// 渠道商身份标识
        /// </summary>
        [XmlElement("channel_isv_id")]
        public string ChannelIsvId { get; set; }

        /// <summary>
        /// 渠道商侧开通授权号，需在商户纬度唯一
        /// </summary>
        [XmlElement("channel_out_biz_no")]
        public string ChannelOutBizNo { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }
    }
}
