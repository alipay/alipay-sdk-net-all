using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApeprojectCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApeprojectCreateModel : AopObject
    {
        /// <summary>
        /// 实际接入推荐项目的商家PID
        /// </summary>
        [XmlElement("actual_merchant_id")]
        public string ActualMerchantId { get; set; }

        /// <summary>
        /// 代商户操作的调用者(ISV)信息，如果是商家自身操作，就填商家ID，如果ISV代为操作，就填ISV ID
        /// </summary>
        [XmlElement("invoker_id")]
        public string InvokerId { get; set; }

        /// <summary>
        /// 商家的PID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 实际接入推荐项目的小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// apemng分配的租户ID（使用前需要和apemng系统对接，由apemng系统人员分配租户ID）
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 商家在蚂蚁推荐引擎创建的项目id，当project_id为空时表示新建项目，否则为修改项目。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 将要创建project的项目名字（中英文都可以）
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 推荐策略，包括优先推荐倾向、疲劳度、多样性等策略
        /// </summary>
        [XmlElement("recommend_strategy")]
        public ApeRecommendStrategy RecommendStrategy { get; set; }

        /// <summary>
        /// 创建project的模版，如果是测试项目，填test，如果是正式项目，填normal，如果有特殊需要，和apemng系统人员确认
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
