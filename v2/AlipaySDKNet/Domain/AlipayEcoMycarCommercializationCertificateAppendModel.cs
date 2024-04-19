using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarCommercializationCertificateAppendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarCommercializationCertificateAppendModel : AopObject
    {
        /// <summary>
        /// 补增凭证详情
        /// </summary>
        [XmlElement("certificate_info")]
        public CommercializationCertificateInfo CertificateInfo { get; set; }

        /// <summary>
        /// 支付宝的用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 操作流水号 商户侧唯一 ，幂等键
        /// </summary>
        [XmlElement("operate_serial_number")]
        public string OperateSerialNumber { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
