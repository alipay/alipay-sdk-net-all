using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NppShowQrCodeDataDTO Data Structure.
    /// </summary>
    [Serializable]
    public class NppShowQrCodeDataDTO : AopObject
    {
        /// <summary>
        /// 地址描述
        /// </summary>
        [XmlElement("address_des")]
        public string AddressDes { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("goods_des")]
        public string GoodsDes { get; set; }

        /// <summary>
        /// 海报
        /// </summary>
        [XmlElement("placard_url")]
        public string PlacardUrl { get; set; }

        /// <summary>
        /// 展码信息
        /// </summary>
        [XmlArray("qr_code_list")]
        [XmlArrayItem("npp_qr_code_d_t_o")]
        public List<NppQrCodeDTO> QrCodeList { get; set; }

        /// <summary>
        /// 时间描述
        /// </summary>
        [XmlElement("time_des")]
        public string TimeDes { get; set; }
    }
}
