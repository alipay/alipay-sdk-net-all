using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvMerchantShop Data Structure.
    /// </summary>
    [Serializable]
    public class IsvMerchantShop : AopObject
    {
        /// <summary>
        /// 商户门店地址
        /// </summary>
        [XmlElement("address")]
        public MerchantShopAddress Address { get; set; }

        /// <summary>
        /// 意向设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 商户联系电话
        /// </summary>
        [XmlElement("merchant_phone")]
        public string MerchantPhone { get; set; }

        /// <summary>
        /// 渠道侧门店编号
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("out_shop_name")]
        public string OutShopName { get; set; }
    }
}
