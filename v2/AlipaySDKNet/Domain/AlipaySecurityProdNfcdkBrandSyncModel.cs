using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdNfcdkBrandSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdNfcdkBrandSyncModel : AopObject
    {
        /// <summary>
        /// 用户账号名称，分享时选择的用户名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 同步的操作类型
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 蓝牙名称
        /// </summary>
        [XmlElement("ble_name")]
        public string BleName { get; set; }

        /// <summary>
        /// 用户钥匙绑定渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 钥匙基本信息
        /// </summary>
        [XmlElement("dk_info")]
        public string DkInfo { get; set; }

        /// <summary>
        /// 钥匙使用次数
        /// </summary>
        [XmlElement("dk_max_count")]
        public long DkMaxCount { get; set; }

        /// <summary>
        /// 子钥匙有效期结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 钥匙唯一ID，用于标识钥匙信息
        /// </summary>
        [XmlElement("key_id")]
        public string KeyId { get; set; }

        /// <summary>
        /// 钥匙类型
        /// </summary>
        [XmlElement("key_type")]
        public string KeyType { get; set; }

        /// <summary>
        /// 蓝牙地址，需保障蓝牙地址的唯一性
        /// </summary>
        [XmlElement("mac")]
        public string Mac { get; set; }

        /// <summary>
        /// 主钥匙所属的子钥匙账户
        /// </summary>
        [XmlElement("master_account_no")]
        public string MasterAccountNo { get; set; }

        /// <summary>
        /// 子钥匙所属的主钥匙keyId
        /// </summary>
        [XmlElement("master_key_id")]
        public string MasterKeyId { get; set; }

        /// <summary>
        /// 用户在车企app绑定的账号
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// nfc补充信息
        /// </summary>
        [XmlElement("nfc_info")]
        public string NfcInfo { get; set; }

        /// <summary>
        /// 通信协议类型
        /// </summary>
        [XmlElement("protocol_type")]
        public string ProtocolType { get; set; }

        /// <summary>
        /// 子钥匙有效期开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 钥匙状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 同步时间戳
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// IIFAA中控设备唯一标识
        /// </summary>
        [XmlElement("tuid")]
        public string Tuid { get; set; }
    }
}
