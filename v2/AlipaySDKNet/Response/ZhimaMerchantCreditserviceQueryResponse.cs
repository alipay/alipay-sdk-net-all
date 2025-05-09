using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantCreditserviceQueryResponse.
    /// </summary>
    public class ZhimaMerchantCreditserviceQueryResponse : AopResponse
    {
        /// <summary>
        /// 信用服务基础信息配置
        /// </summary>
        [XmlElement("base_info_config")]
        public BaseInfoApiConfig BaseInfoConfig { get; set; }

        /// <summary>
        /// 信用服务创建模式，枚举如下： * DIRECT_MERCHANT：直连商户（直连模式）。 * ZFT_MERCHANT：直付通商户(间联模式)。
        /// </summary>
        [XmlElement("create_type")]
        public string CreateType { get; set; }

        /// <summary>
        /// 信用服务ID
        /// </summary>
        [XmlElement("credit_service_id")]
        public string CreditServiceId { get; set; }

        /// <summary>
        /// 多评估方案信用服务风控配置。此字段为复杂模型。
        /// </summary>
        [XmlArray("evaluation_risk_configs")]
        [XmlArrayItem("risk_api_config")]
        public List<RiskApiConfig> EvaluationRiskConfigs { get; set; }

        /// <summary>
        /// 信用服务的创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 信用服务的修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 信用服务版本的下线时间
        /// </summary>
        [XmlElement("gmt_offline")]
        public string GmtOffline { get; set; }

        /// <summary>
        /// 信用服务版本的上线时间
        /// </summary>
        [XmlElement("gmt_online")]
        public string GmtOnline { get; set; }

        /// <summary>
        /// 信用服务版本的审批通过时间
        /// </summary>
        [XmlElement("gmt_review")]
        public string GmtReview { get; set; }

        /// <summary>
        /// 间连模式创建信用服务的ISV商户ID
        /// </summary>
        [XmlElement("isv_id")]
        public string IsvId { get; set; }

        /// <summary>
        /// 提供信用服务的商户的ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 提供信用服务的商户的名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 先用后付经营的小程序
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 信用服务的工单ID
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 信用服务守护配置
        /// </summary>
        [XmlElement("promise_config")]
        public PromiseApiConfig PromiseConfig { get; set; }

        /// <summary>
        /// 信用服务版本审核失败时的原因描述
        /// </summary>
        [XmlElement("review_failed_msg")]
        public string ReviewFailedMsg { get; set; }

        /// <summary>
        /// 信用服务版本审核状态，可取值： init(未提交)； reviewing(审核中)； review_failed(审核驳回)； review_passed(审核通过)
        /// </summary>
        [XmlElement("review_status")]
        public string ReviewStatus { get; set; }

        /// <summary>
        /// 信用服务风控配置
        /// </summary>
        [XmlElement("risk_config")]
        public RiskApiConfig RiskConfig { get; set; }

        /// <summary>
        /// 信用服务版本状态，可取值： init(未上线)； to_be_published(待发布)； online_processing(上线中)； online(已上线)； offline(已下线)； notOnline(未上线)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 信用服务版本的版本号
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
