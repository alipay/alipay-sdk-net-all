using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectinfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpenserulesProjectinfoModifyModel : AopObject
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 有效期截止（yyyy-MM-dd HH:mm:ss） 特殊说明： 1）与起始时间必须同时传，且大于起始时间 2）不传则默认不修改
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 有效期起始（yyyy-MM-dd HH:mm:ss） 特殊说明： 1）与截止时间必须同时传，且小于截止时间 2）不传入则默认不修改
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名 特殊说明：不传入则默认不修改
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }
    }
}
