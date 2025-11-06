using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandDigitalgroupShopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandDigitalgroupShopQueryModel : AopObject
    {
        /// <summary>
        /// AMAP("AMAP", "AMAP", "高德", "高德")
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 高德渠道门店，和数字化门店ID必须要传1个
        /// </summary>
        [XmlElement("channel_shop_id")]
        public string ChannelShopId { get; set; }

        /// <summary>
        /// 数字话门店ID，和渠道门店2个必须要填写1个，以数字化门店为主查
        /// </summary>
        [XmlElement("digital_poi_id")]
        public string DigitalPoiId { get; set; }
    }
}
