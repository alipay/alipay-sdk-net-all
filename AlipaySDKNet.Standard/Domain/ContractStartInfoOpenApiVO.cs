using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractStartInfoOpenApiVO Data Structure.
    /// </summary>
    [Serializable]
    public class ContractStartInfoOpenApiVO : AopObject
    {
        /// <summary>
        /// 是否接受了差于与独立第三方公司的类似合作条款
        /// </summary>
        [XmlElement("accept_diff_others")]
        public bool AcceptDiffOthers { get; set; }

        /// <summary>
        /// 是否接受了差于与独立第三方公司的类似合作条款说明
        /// </summary>
        [XmlElement("accept_diff_others_explain")]
        public string AcceptDiffOthersExplain { get; set; }

        /// <summary>
        /// 金额类型
        /// </summary>
        [XmlElement("amount_type")]
        public string AmountType { get; set; }

        /// <summary>
        /// 合约对手方
        /// </summary>
        [XmlArray("anti_participants")]
        [XmlArrayItem("participant_info_v_o")]
        public List<ParticipantInfoVO> AntiParticipants { get; set; }

        /// <summary>
        /// 申请日期
        /// </summary>
        [XmlElement("applicant_date")]
        public string ApplicantDate { get; set; }

        /// <summary>
        /// 倒签报备附件
        /// </summary>
        [XmlArray("backdate_report_file")]
        [XmlArrayItem("inter_trade_file_info_v_o")]
        public List<InterTradeFileInfoVO> BackdateReportFile { get; set; }

        /// <summary>
        /// 提交人
        /// </summary>
        [XmlElement("committer")]
        public string Committer { get; set; }

        /// <summary>
        /// 合约金额 单位：分
        /// </summary>
        [XmlElement("contract_amount_cent")]
        public string ContractAmountCent { get; set; }

        /// <summary>
        /// 合约金额 币种
        /// </summary>
        [XmlElement("contract_amount_currency")]
        public string ContractAmountCurrency { get; set; }

        /// <summary>
        /// 合约金额描述
        /// </summary>
        [XmlElement("contract_amount_extra")]
        public string ContractAmountExtra { get; set; }

        /// <summary>
        /// 合约金额折合人民币
        /// </summary>
        [XmlElement("contract_amount_to_cny")]
        public string ContractAmountToCny { get; set; }

        /// <summary>
        /// 合同分类
        /// </summary>
        [XmlElement("contract_category")]
        public string ContractCategory { get; set; }

        /// <summary>
        /// 合约名称
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 合同状态
        /// </summary>
        [XmlElement("contract_status")]
        public string ContractStatus { get; set; }

        /// <summary>
        /// 合同有效期类型
        /// </summary>
        [XmlElement("contract_valid_type")]
        public string ContractValidType { get; set; }

        /// <summary>
        /// 提交人部门id
        /// </summary>
        [XmlElement("dept_id")]
        public string DeptId { get; set; }

        /// <summary>
        /// 合同结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 合约文件列表
        /// </summary>
        [XmlArray("files")]
        [XmlArrayItem("inter_trade_file_info_v_o")]
        public List<InterTradeFileInfoVO> Files { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 是否为框架合同,默认False
        /// </summary>
        [XmlElement("is_frame_contract")]
        public bool IsFrameContract { get; set; }

        /// <summary>
        /// 是否有限制我方业务范畴、业务地域的非竞争条款
        /// </summary>
        [XmlElement("limit_business_area")]
        public bool LimitBusinessArea { get; set; }

        /// <summary>
        /// 是否有限制我方业务范畴、业务地域的非竞争条款说明
        /// </summary>
        [XmlElement("limit_business_area_explain")]
        public string LimitBusinessAreaExplain { get; set; }

        /// <summary>
        /// 是否有限制我方与其他第三方合作的独家/排他条款
        /// </summary>
        [XmlElement("limit_cooperate")]
        public bool LimitCooperate { get; set; }

        /// <summary>
        /// 是否有限制我方与其他第三方合作的独家/排他条款说明
        /// </summary>
        [XmlElement("limit_cooperate_explain")]
        public string LimitCooperateExplain { get; set; }

        /// <summary>
        /// 合同约定失效方式
        /// </summary>
        [XmlElement("lose_effect_method")]
        public string LoseEffectMethod { get; set; }

        /// <summary>
        /// 主合同编号
        /// </summary>
        [XmlElement("main_contract_no")]
        public string MainContractNo { get; set; }

        /// <summary>
        /// 付款方
        /// </summary>
        [XmlElement("payment_party")]
        public string PaymentParty { get; set; }

        /// <summary>
        /// 签约一年内的预估发生额 单位：分
        /// </summary>
        [XmlElement("predict_amount_in_year_cent")]
        public string PredictAmountInYearCent { get; set; }

        /// <summary>
        /// 签约一年内的预估发生额 币种
        /// </summary>
        [XmlElement("predict_amount_in_year_currency")]
        public string PredictAmountInYearCurrency { get; set; }

        /// <summary>
        /// 签约一年内的预估发生额描述
        /// </summary>
        [XmlElement("predict_amount_in_year_extra")]
        public string PredictAmountInYearExtra { get; set; }

        /// <summary>
        /// 签约一年内的预估发生额折合人民币
        /// </summary>
        [XmlElement("predict_amount_in_year_to_cny")]
        public string PredictAmountInYearToCny { get; set; }

        /// <summary>
        /// 定价策略
        /// </summary>
        [XmlElement("price_type")]
        public string PriceType { get; set; }

        /// <summary>
        /// 定价政策说明
        /// </summary>
        [XmlElement("price_type_explain")]
        public string PriceTypeExplain { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 合约本方
        /// </summary>
        [XmlArray("self_participants")]
        [XmlArrayItem("participant_info_v_o")]
        public List<ParticipantInfoVO> SelfParticipants { get; set; }

        /// <summary>
        /// 合同开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 合同约定生效方式
        /// </summary>
        [XmlElement("take_effect_method")]
        public string TakeEffectMethod { get; set; }

        /// <summary>
        /// 是否模版协议
        /// </summary>
        [XmlElement("template_protocol")]
        public bool TemplateProtocol { get; set; }

        /// <summary>
        /// 是否模版协议说明
        /// </summary>
        [XmlElement("template_protocol_explain")]
        public string TemplateProtocolExplain { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 历史审批信息
        /// </summary>
        [XmlArray("workflow_log_list")]
        [XmlArrayItem("inter_trade_approval_workflow_operate_log_v_o")]
        public List<InterTradeApprovalWorkflowOperateLogVO> WorkflowLogList { get; set; }
    }
}
