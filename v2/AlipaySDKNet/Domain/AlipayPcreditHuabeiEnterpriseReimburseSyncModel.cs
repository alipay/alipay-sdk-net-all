using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiEnterpriseReimburseSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiEnterpriseReimburseSyncModel : AopObject
    {
        /// <summary>
        /// 企业单据id
        /// </summary>
        [XmlElement("biz_reimburse_id")]
        public string BizReimburseId { get; set; }

        /// <summary>
        /// 单据结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 单据开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 若有途径城市，填写途径城市，没有填写单据名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
