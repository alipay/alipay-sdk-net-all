using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAssistantMemberzptaskSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAssistantMemberzptaskSubmitModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("company_info_list")]
        [XmlArrayItem("assistant_company_simple_info")]
        public List<AssistantCompanySimpleInfo> CompanyInfoList { get; set; }

        /// <summary>
        /// 唯一键，幂等控制，同一id不允许多次发起
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 合作伙伴侧的商户id，后续发起的时候会校验是否一致
        /// </summary>
        [XmlElement("partner_corp_id")]
        public string PartnerCorpId { get; set; }

        /// <summary>
        /// 当前提交智评任务的用户所属商户的名称
        /// </summary>
        [XmlElement("partner_corp_name")]
        public string PartnerCorpName { get; set; }

        /// <summary>
        /// 合作伙伴侧的用户id，后续发起的时候会校验是否一致
        /// </summary>
        [XmlElement("partner_user_id")]
        public string PartnerUserId { get; set; }

        /// <summary>
        /// 提交的任务类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
