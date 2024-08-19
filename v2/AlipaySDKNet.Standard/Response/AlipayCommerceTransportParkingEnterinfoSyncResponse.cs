using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportParkingEnterinfoSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportParkingEnterinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 用户签约的代扣场景字符集，多个英文逗号分割，当车场为ORC识别车牌的场景，返回值包含PLATE_PAY时，表示代扣协议可用。 当车场为ETC设备识别车牌，返回值包含ETC_PAY时表示协议可用。当用户未签约任何代扣场景时返回NO_AGREEMENT_SCENE
        /// </summary>
        [XmlElement("agreement_scene")]
        public string AgreementScene { get; set; }

        /// <summary>
        /// 具体错误code
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 具体错误描述
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }

        /// <summary>
        /// 支付宝停车纪录流水号，串联一次停车行为；
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
