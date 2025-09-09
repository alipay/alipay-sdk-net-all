using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlimamaPrincipalExtendInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlimamaPrincipalExtendInfo : AopObject
    {
        /// <summary>
        /// 商家自定义账户名称
        /// </summary>
        [XmlElement("principal_define_name")]
        public string PrincipalDefineName { get; set; }

        /// <summary>
        /// 二代邮箱
        /// </summary>
        [XmlElement("second_email")]
        public string SecondEmail { get; set; }

        /// <summary>
        /// 二代支付宝oid
        /// </summary>
        [XmlElement("second_oid")]
        public string SecondOid { get; set; }

        /// <summary>
        /// 风控识别商家关联的支付宝企业账号和资质id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 商家营业执照名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 店铺类型
        /// </summary>
        [XmlElement("store_type")]
        public string StoreType { get; set; }
    }
}
