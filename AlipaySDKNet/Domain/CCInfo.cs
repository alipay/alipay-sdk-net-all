using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CCInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CCInfo : AopObject
    {
        /// <summary>
        /// 收件人详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 清关资质等扩展信息
        /// </summary>
        [XmlElement("cc_ext")]
        public string CcExt { get; set; }

        /// <summary>
        /// 国家及地区编码
        /// </summary>
        [XmlElement("cr_code")]
        public string CrCode { get; set; }

        /// <summary>
        /// 国家及地区描述
        /// </summary>
        [XmlElement("cr_desc")]
        public string CrDesc { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 物料中文名
        /// </summary>
        [XmlElement("item_alias_name")]
        public string ItemAliasName { get; set; }

        /// <summary>
        /// 物料描述：含材质、用途
        /// </summary>
        [XmlElement("item_desc")]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 物料英文名
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 物料份数
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 收件公司全名
        /// </summary>
        [XmlElement("recipient_entity_name")]
        public string RecipientEntityName { get; set; }

        /// <summary>
        /// 收件人姓名: first name + last name 空格分隔
        /// </summary>
        [XmlElement("recipient_name")]
        public string RecipientName { get; set; }

        /// <summary>
        /// 收件人电话
        /// </summary>
        [XmlElement("recipient_phone")]
        public string RecipientPhone { get; set; }

        /// <summary>
        /// 申报价值单件价
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [XmlElement("zip_code")]
        public string ZipCode { get; set; }
    }
}
