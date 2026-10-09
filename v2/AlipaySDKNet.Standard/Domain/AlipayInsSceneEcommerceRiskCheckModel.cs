using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommerceRiskCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommerceRiskCheckModel : AopObject
    {
        /// <summary>
        /// 电商买家
        /// </summary>
        [XmlElement("buyer")]
        public EcomBuyerDTO Buyer { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        [XmlElement("item")]
        public EcomItemDTO Item { get; set; }

        /// <summary>
        /// 订单
        /// </summary>
        [XmlElement("order")]
        public EcomOrderDTO Order { get; set; }

        /// <summary>
        /// 请求幂等单号，如果不传入，系统自动生成
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 合作商标识，由蚂蚁保分配
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 产品方案ID，由蚂蚁保分配
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }

        /// <summary>
        /// 风控准入类型，用于标识时间风控准入的环节
        /// </summary>
        [XmlElement("risk_access_type")]
        public string RiskAccessType { get; set; }

        /// <summary>
        /// 电商卖家
        /// </summary>
        [XmlElement("seller")]
        public EcomSellerDTO Seller { get; set; }
    }
}
