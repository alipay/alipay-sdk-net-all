using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorIotbspFwjnfcSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorIotbspFwjnfcSyncModel : AopObject
    {
        /// <summary>
        /// nfc设备BizTid
        /// </summary>
        [XmlElement("nfc_biz_tid")]
        public string NfcBizTid { get; set; }

        /// <summary>
        /// nfc设备Sn编码
        /// </summary>
        [XmlElement("nfc_sn")]
        public string NfcSn { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 上位机biztid
        /// </summary>
        [XmlElement("upper_biz_tid")]
        public string UpperBizTid { get; set; }

        /// <summary>
        /// 上位机sn
        /// </summary>
        [XmlElement("upper_sn")]
        public string UpperSn { get; set; }

        /// <summary>
        /// isv小程序跳转url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
