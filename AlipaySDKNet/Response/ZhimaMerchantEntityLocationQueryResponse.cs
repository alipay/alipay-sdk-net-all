using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantEntityLocationQueryResponse.
    /// </summary>
    public class ZhimaMerchantEntityLocationQueryResponse : AopResponse
    {
        /// <summary>
        /// 充电宝位置
        /// </summary>
        [XmlElement("address_desc")]
        public string AddressDesc { get; set; }

        /// <summary>
        /// 充电宝小程序的链接
        /// </summary>
        [XmlElement("applet_link")]
        public string AppletLink { get; set; }

        /// <summary>
        /// 充电宝的品牌
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 距离
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 是否存在
        /// </summary>
        [XmlElement("exist")]
        public bool Exist { get; set; }

        /// <summary>
        /// h5链接
        /// </summary>
        [XmlElement("h_five_link")]
        public string HFiveLink { get; set; }

        /// <summary>
        /// 充电宝支持的接口类型
        /// </summary>
        [XmlElement("interface_type")]
        public string InterfaceType { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 充电宝充电价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 支付宝配置的文案
        /// </summary>
        [XmlElement("zfb_text_content")]
        public string ZfbTextContent { get; set; }
    }
}
