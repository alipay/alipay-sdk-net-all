using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcShopSharecodeGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcShopSharecodeGenerateModel : AopObject
    {
        /// <summary>
        /// 员工id，可通过查询企业码员工详情获取
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业id，可通过查询入驻企业码企业详情获取
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 用户支付宝uid，可通过查询企业码员工详情获取
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 企业码商户相关页面对应编码，可选值： LIST-列表页； DETAIL-详情页
        /// </summary>
        [XmlElement("page_code")]
        public string PageCode { get; set; }

        /// <summary>
        /// 企业码门店id，可通过查询企业码门店详情获取
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 费控使用规则id，可通过查询费用制度下使用规则详情获取
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }

        /// <summary>
        /// 二级场景码，可选值： REACH_SHOP-到店； REACH_SHOP_OIL-到店加油
        /// </summary>
        [XmlElement("sub_scene")]
        public string SubScene { get; set; }

        /// <summary>
        /// 用户uid，可通过查询企业码员工详情获取
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
