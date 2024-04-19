using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelFliggyAuthorityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelFliggyAuthorityQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝运营店ID
        /// </summary>
        [XmlElement("global_shop_id")]
        public string GlobalShopId { get; set; }

        /// <summary>
        /// 登录账户的操作员ID
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 用户类型: 主账户 or 操作员. 主账号:MAIN_ACCOUNT 操作员:OPERATOR
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 登录账户归属的机构PID
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 飞猪门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
