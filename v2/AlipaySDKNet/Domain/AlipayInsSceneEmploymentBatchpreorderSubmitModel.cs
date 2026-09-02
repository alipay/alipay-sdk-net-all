using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEmploymentBatchpreorderSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEmploymentBatchpreorderSubmitModel : AopObject
    {
        /// <summary>
        /// 被保人信息
        /// </summary>
        [XmlArray("employee_list")]
        [XmlArrayItem("ins_employee")]
        public List<InsEmployee> EmployeeList { get; set; }

        /// <summary>
        /// 投保人信息
        /// </summary>
        [XmlElement("merchant")]
        public InsCompany Merchant { get; set; }

        /// <summary>
        /// 外部业务幂等单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部方案ID
        /// </summary>
        [XmlElement("out_plan_id")]
        public string OutPlanId { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// D天 M月 Y年，比如1天则是1D
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 产品方案ID
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
