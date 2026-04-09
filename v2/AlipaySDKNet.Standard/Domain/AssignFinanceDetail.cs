using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssignFinanceDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AssignFinanceDetail : AopObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [XmlElement("alipay_pid")]
        public string AlipayPid { get; set; }

        /// <summary>
        /// 分配动作： "ASSIGN"-转入 "CUT"-转出
        /// </summary>
        [XmlElement("apply_type_str")]
        public string ApplyTypeStr { get; set; }

        /// <summary>
        /// 分配金额(元)
        /// </summary>
        [XmlElement("format_available_amount")]
        public string FormatAvailableAmount { get; set; }

        /// <summary>
        /// 普通红包(元)
        /// </summary>
        [XmlElement("format_benefit_amount")]
        public string FormatBenefitAmount { get; set; }

        /// <summary>
        /// 授信(元)
        /// </summary>
        [XmlElement("format_credit_amount")]
        public string FormatCreditAmount { get; set; }

        /// <summary>
        /// 流量红包(元)
        /// </summary>
        [XmlElement("format_marketing_amount")]
        public string FormatMarketingAmount { get; set; }

        /// <summary>
        /// 现金(元)
        /// </summary>
        [XmlElement("format_principal_amount")]
        public string FormatPrincipalAmount { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("principal_name")]
        public string PrincipalName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 钱包类型名称： 通用钱包-INTELLIGENT 外投钱包-XAB_BP
        /// </summary>
        [XmlElement("scene_code_str")]
        public string SceneCodeStr { get; set; }

        /// <summary>
        /// 分配时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
