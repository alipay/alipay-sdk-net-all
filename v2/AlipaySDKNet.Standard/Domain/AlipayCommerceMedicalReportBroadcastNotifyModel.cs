using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalReportBroadcastNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalReportBroadcastNotifyModel : AopObject
    {
        /// <summary>
        /// 2088用户
        /// </summary>
        [XmlElement("alipay_user")]
        public string AlipayUser { get; set; }

        /// <summary>
        /// AQ用户
        /// </summary>
        [XmlElement("aq_user")]
        public string AqUser { get; set; }

        /// <summary>
        /// 报道信息
        /// </summary>
        [XmlElement("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 外部业务 id
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 外部业务类型
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
