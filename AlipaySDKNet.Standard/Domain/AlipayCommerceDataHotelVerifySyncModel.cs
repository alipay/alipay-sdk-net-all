using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceDataHotelVerifySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDataHotelVerifySyncModel : AopObject
    {
        /// <summary>
        /// 酒店扫码核验业务场景下，核验人基本信息页面的展示配置
        /// </summary>
        [XmlElement("certify_config")]
        public CertifyConfig CertifyConfig { get; set; }

        /// <summary>
        /// 酒店扫码核验场景中码的链接
        /// </summary>
        [XmlElement("code_values")]
        public string CodeValues { get; set; }

        /// <summary>
        /// 扩展信息。 若有信息通过扩展字段来传，key值需要联系支付宝技术人员进行配置
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("scenic_ext_info")]
        public List<ScenicExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// PSB服务商侧酒店信息
        /// </summary>
        [XmlElement("psb_hotel_info")]
        public PsbHotelInfo PsbHotelInfo { get; set; }

        /// <summary>
        /// 门店信息通过MIF蚂蚁门店进件后，返回的shop_id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 接入服务商的标识，请提前联系支付宝技术人员来配置
        /// </summary>
        [XmlElement("source_code")]
        public string SourceCode { get; set; }
    }
}
