using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIotdeviceOnlinedataUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIotdeviceOnlinedataUploadModel : AopObject
    {
        /// <summary>
        /// 设备有效时长（小于等于86400秒）
        /// </summary>
        [XmlElement("device_online_time")]
        public long DeviceOnlineTime { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备对应政策类型(无政策(NO_POLICY),现金返佣(CASH_POLICY),屏幕共享(SHAREING_POLICY))
        /// </summary>
        [XmlElement("policy_type")]
        public string PolicyType { get; set; }

        /// <summary>
        /// 结算支付宝账号：结算支付宝账号（商户）、结算支付宝账号（服务商）
        /// </summary>
        [XmlElement("settled_alipay_id")]
        public string SettledAlipayId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 签约支付宝账号PID(2088开头): 商家支付宝账号（用于与蚂蚁签约的支付宝账号）、 外部服务商支付宝账号（用于与蚂蚁签约的支付宝账号）
        /// </summary>
        [XmlElement("signed_alipay_id")]
        public string SignedAlipayId { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        [XmlElement("supplier_sn")]
        public string SupplierSn { get; set; }

        /// <summary>
        /// 上传日期
        /// </summary>
        [XmlElement("upload_date")]
        public string UploadDate { get; set; }
    }
}
