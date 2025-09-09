using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtcAuthResult Data Structure.
    /// </summary>
    [Serializable]
    public class EtcAuthResult : AopObject
    {
        /// <summary>
        /// 支付宝授权协议号
        /// </summary>
        [XmlElement("auth_agreement_no")]
        public string AuthAgreementNo { get; set; }

        /// <summary>
        /// 认证完成时间
        /// </summary>
        [XmlElement("auth_time")]
        public string AuthTime { get; set; }

        /// <summary>
        /// ETC卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 发行机构名称
        /// </summary>
        [XmlElement("issue_name")]
        public string IssueName { get; set; }

        /// <summary>
        /// 外部协议号
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }

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

        /// <summary>
        /// 授权状态
        /// </summary>
        [XmlElement("service_status")]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// 解除认证完成时间
        /// </summary>
        [XmlElement("unauth_time")]
        public string UnauthTime { get; set; }
    }
}
