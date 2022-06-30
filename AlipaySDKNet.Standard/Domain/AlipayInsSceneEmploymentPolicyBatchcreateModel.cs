using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEmploymentPolicyBatchcreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEmploymentPolicyBatchcreateModel : AopObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 员工信息
        /// </summary>
        [XmlArray("employee_list")]
        [XmlArrayItem("ins_employee")]
        public List<InsEmployee> EmployeeList { get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        [XmlElement("insure_time")]
        public string InsureTime { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [XmlElement("merchant")]
        public InsCompany Merchant { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保障期限
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 推荐流水号
        /// </summary>
        [XmlElement("recom_flow_no")]
        public string RecomFlowNo { get; set; }

        /// <summary>
        /// 投保场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
