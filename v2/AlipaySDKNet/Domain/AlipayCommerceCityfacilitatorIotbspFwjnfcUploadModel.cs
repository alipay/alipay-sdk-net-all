using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorIotbspFwjnfcUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorIotbspFwjnfcUploadModel : AopObject
    {
        /// <summary>
        /// 线圈链接被读取时事件的时间戳，单位为秒或毫秒的时间戳
        /// </summary>
        [XmlElement("fetch_time")]
        public string FetchTime { get; set; }

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

        /// <summary>
        /// NFC模块烧录的链接，通过初始化接口获得的链接内容
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
