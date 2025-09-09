using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneCommonOrderApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneCommonOrderApplyModel : AopObject
    {
        /// <summary>
        /// 业务时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 投保人
        /// </summary>
        [XmlElement("holder_user")]
        public InsOpenUserDTO HolderUser { get; set; }

        /// <summary>
        /// 被保人
        /// </summary>
        [XmlElement("insured_user")]
        public InsOpenUserDTO InsuredUser { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 预下单号
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 产品方案id，，预下单接口返回的
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }
    }
}
