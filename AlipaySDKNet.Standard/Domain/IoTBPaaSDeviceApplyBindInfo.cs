using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IoTBPaaSDeviceApplyBindInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IoTBPaaSDeviceApplyBindInfo : AopObject
    {
        /// <summary>
        /// 支付宝登录账号
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
