using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsuredVO Data Structure.
    /// </summary>
    [Serializable]
    public class InsuredVO : AopObject
    {
        /// <summary>
        /// 被保人出生日期 格式： yyyy-MM-dd
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 被保人证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 公民身份证 I，户口簿 H，港澳居民来往内地通行证 GJ，台湾居民来往大陆通行证 TB，护照(指他国护照) P，往来港澳通行证 GA，港澳居民居住证 GARP，台湾居民居住证 TWRP
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 被保人性别  男-M 女-F
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 被保人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 被保人电话号码
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 名称 代码 本人 0 配偶 1 父母 2 子女 3 其他 14
        /// </summary>
        [XmlElement("relation_to_ph")]
        public string RelationToPh { get; set; }

        /// <summary>
        /// 子订单号
        /// </summary>
        [XmlElement("sub_order_no")]
        public string SubOrderNo { get; set; }
    }
}
