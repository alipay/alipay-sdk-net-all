using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIotDeviceQueryResponse.
    /// </summary>
    public class AlipayMerchantIotDeviceQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户类型。direct表示直连商户，indirect表示间连商户。
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 设备绑定的商户支付宝pid。直连场景为商户收单pid，间连场景为商户smid绑定的pid。
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 设备绑定的门店ID。
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商户smid。直连场景为空。
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
