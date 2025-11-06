using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdNfcdkPartsModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdNfcdkPartsModifyModel : AopObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 车辆N模块的tagId
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 车辆NFC模组的sn号
        /// </summary>
        [XmlElement("tag_sn")]
        public string TagSn { get; set; }

        /// <summary>
        /// 中控设备唯一标识
        /// </summary>
        [XmlElement("tuid")]
        public string Tuid { get; set; }

        /// <summary>
        /// 车辆的车架号
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
