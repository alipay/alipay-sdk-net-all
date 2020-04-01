using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcBindModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcBindModifyModel : AopObject
    {
        /// <summary>
        /// 绑定申请协议号
        /// </summary>
        [XmlElement("bind_agreement_no")]
        public string BindAgreementNo { get; set; }

        /// <summary>
        /// 用户办理ETC时预留的手机号
        /// </summary>
        [XmlElement("binded_mobile")]
        public string BindedMobile { get; set; }

        /// <summary>
        /// 卡号，带省份前缀
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// OBUID，设备号
        /// </summary>
        [XmlElement("device_no")]
        public string DeviceNo { get; set; }
    }
}
