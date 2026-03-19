using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinLendapplystatusNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinLendapplystatusNotifyModel : AopObject
    {
        /// <summary>
        /// 协议文件列表
        /// </summary>
        [XmlArray("agreement_file_list")]
        [XmlArrayItem("agreement_file")]
        public List<AgreementFile> AgreementFileList { get; set; }

        /// <summary>
        /// 星河侧唯一申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 需要替换的审核文件列表
        /// </summary>
        [XmlArray("approve_file_list")]
        [XmlArrayItem("carfin_mortgage_received_file")]
        public List<CarfinMortgageReceivedFile> ApproveFileList { get; set; }

        /// <summary>
        /// 授信信息列表 （支用审批未通过时可传）
        /// </summary>
        [XmlArray("credit_list")]
        [XmlArrayItem("credit")]
        public List<Credit> CreditList { get; set; }

        /// <summary>
        /// 放款信息
        /// </summary>
        [XmlArray("drawdown_list")]
        [XmlArrayItem("lend_drawdown")]
        public List<LendDrawdown> DrawdownList { get; set; }

        /// <summary>
        /// 担保机构信息
        /// </summary>
        [XmlElement("guarantee_inst")]
        public CarfinGuaranteeInst GuaranteeInst { get; set; }

        /// <summary>
        /// 支用申请单号
        /// </summary>
        [XmlElement("lend_apply_no")]
        public string LendApplyNo { get; set; }

        /// <summary>
        /// 抵押办理渠道 1 - 专网 2 - 公安网
        /// </summary>
        [XmlElement("mortgage_channel")]
        public string MortgageChannel { get; set; }

        /// <summary>
        /// 是否需要换绑卡，放款中断时可选
        /// </summary>
        [XmlElement("need_change_bind_card")]
        public bool NeedChangeBindCard { get; set; }

        /// <summary>
        /// 是否需要加急办理
        /// </summary>
        [XmlElement("need_urgent_processing")]
        public bool NeedUrgentProcessing { get; set; }

        /// <summary>
        /// 机构侧唯一业务编号
        /// </summary>
        [XmlElement("out_apply_no")]
        public string OutApplyNo { get; set; }

        /// <summary>
        /// 外部支用申请单号
        /// </summary>
        [XmlElement("out_lend_apply_no")]
        public string OutLendApplyNo { get; set; }

        /// <summary>
        /// 拒绝码 见拒绝码文档
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 拒绝原因 见拒绝码文档
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 支用申请状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 需要补充的信息列表
        /// </summary>
        [XmlArray("supplement_category_list")]
        [XmlArrayItem("supplement_category_info")]
        public List<SupplementCategoryInfo> SupplementCategoryList { get; set; }

        /// <summary>
        /// 需要补充的原因
        /// </summary>
        [XmlElement("supplement_reason")]
        public string SupplementReason { get; set; }

        /// <summary>
        /// 是否支持先放后抵
        /// </summary>
        [XmlElement("support_lend_before_mortgage")]
        public bool SupportLendBeforeMortgage { get; set; }
    }
}
