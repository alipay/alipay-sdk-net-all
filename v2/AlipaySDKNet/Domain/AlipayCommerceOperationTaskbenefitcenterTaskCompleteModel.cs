using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationTaskbenefitcenterTaskCompleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationTaskbenefitcenterTaskCompleteModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("benefit_list")]
        [XmlArrayItem("benefit_info_d_t_o")]
        public List<BenefitInfoDTO> BenefitList { get; set; }

        /// <summary>
        /// 任务CODE
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }

        /// <summary>
        /// 任务模板CODE
        /// </summary>
        [XmlElement("task_template_code")]
        public string TaskTemplateCode { get; set; }

        /// <summary>
        /// 用户唯一标识 ※支付宝跳转到商户页面的链接会拼接上该参数
        /// </summary>
        [XmlElement("user_unique_code")]
        public string UserUniqueCode { get; set; }
    }
}
