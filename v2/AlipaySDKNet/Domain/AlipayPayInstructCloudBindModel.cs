using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayInstructCloudBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayInstructCloudBindModel : AopObject
    {
        /// <summary>
        /// 绑定时从 N 设备 KD4 接收的 SN
        /// </summary>
        [XmlElement("n_sn")]
        public string NSn { get; set; }

        /// <summary>
        /// 绑定时从 N 设备 KD4 接收的配对码
        /// </summary>
        [XmlElement("pairing_code")]
        public string PairingCode { get; set; }

        /// <summary>
        /// POS 设备唯一标识，建议取 POS 设备 SN 编号，保证每个设备唯一
        /// </summary>
        [XmlElement("pos_id")]
        public string PosId { get; set; }

        /// <summary>
        /// POS所在门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }
    }
}
