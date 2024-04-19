using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantCreditserviceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantCreditserviceCreateModel : AopObject
    {
        /// <summary>
        /// 信用服务基础信息配置，为必传字段。此字段为复杂模型，其中服务名称和服务logo为必传属性。
        /// </summary>
        [XmlElement("base_info_config")]
        public BaseInfoApiConfig BaseInfoConfig { get; set; }

        /// <summary>
        /// 业务流水号，由商户传入，为必传字段。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 信用服务创建模式，枚举如下： * DIRECT_MERCHANT：直连商户（直连模式）。 * ZFT_MERCHANT：直付通商户(间联模式)。
        /// </summary>
        [XmlElement("create_type")]
        public string CreateType { get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        [XmlElement("ext_info_config")]
        public ExtInfoApiConfig ExtInfoConfig { get; set; }

        /// <summary>
        /// 信用服务守护配置，为必传字段。此字段为复杂模型，其中商户服务电话为必传属性。
        /// </summary>
        [XmlElement("promise_config")]
        public PromiseApiConfig PromiseConfig { get; set; }

        /// <summary>
        /// 信用服务风控配置，为必传字段。此字段为复杂模型，其中类目code为必传属性。
        /// </summary>
        [XmlElement("risk_config")]
        public RiskApiConfig RiskConfig { get; set; }

        /// <summary>
        /// 二级商户ID。
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 行业解决方案ID，为必传字段，需要BD或相关产品负责人提供
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 二级商户pid
        /// </summary>
        [XmlElement("sub_pid")]
        public string SubPid { get; set; }
    }
}
