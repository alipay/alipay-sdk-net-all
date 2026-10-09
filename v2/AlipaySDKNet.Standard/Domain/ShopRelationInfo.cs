using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopRelationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopRelationInfo : AopObject
    {
        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("credit_code")]
        public string CreditCode { get; set; }

        /// <summary>
        /// 企信标识企业唯一ID
        /// </summary>
        [XmlElement("ent_id")]
        public string EntId { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ent_name")]
        public string EntName { get; set; }

        /// <summary>
        /// 店铺平台id
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }

        /// <summary>
        /// 店铺平台名称
        /// </summary>
        [XmlElement("platform_name")]
        public string PlatformName { get; set; }

        /// <summary>
        /// 店铺平台类型
        /// </summary>
        [XmlElement("platform_type_code")]
        public string PlatformTypeCode { get; set; }

        /// <summary>
        /// reg_no
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }

        /// <summary>
        /// 关系类型
        /// </summary>
        [XmlElement("rel_type_code")]
        public string RelTypeCode { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 是否在营
        /// </summary>
        [XmlElement("shop_status")]
        public string ShopStatus { get; set; }

        /// <summary>
        /// 店铺类型
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }
    }
}
