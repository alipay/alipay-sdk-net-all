using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorIotbspFwjnfcBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorIotbspFwjnfcBindModel : AopObject
    {
        /// <summary>
        /// NFC模块SN
        /// </summary>
        [XmlElement("nfc_sn")]
        public string NfcSn { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 上位机SN，具体取值为服务商设备唯一标识
        /// </summary>
        [XmlElement("upper_sn")]
        public string UpperSn { get; set; }
    }
}
