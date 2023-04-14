using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcConsumeDetailBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcConsumeDetailBatchqueryModel : AopObject
    {
        /// <summary>
        /// 共同账户ID，有企业ID可不传
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号，有企业ID可不传
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 截止时间，格式：yyyy-MM-dd HH:mm:ss，起始和截止时间不能大于31天。
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 企业ID，推荐查询方式
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 页数，本参数为空或小于1默认显示第一页。
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页大小，本参数为空或小于1默认20条，超过20默认按20条查询；不足20条则按实际记录数返回。
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 起始时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
