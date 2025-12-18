using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommissionRelationDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CommissionRelationDTO : AopObject
    {
        /// <summary>
        /// 授权结果信息
        /// </summary>
        [XmlElement("auth_result")]
        public bool AuthResult { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("merchant_role_id")]
        public string MerchantRoleId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
