using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpReportCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpReportCreateModel : AopObject
    {
        /// <summary>
        /// 合作方客户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 出具报告的企业证件号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 所出具报告的企业名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 报告订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 合作方订单号，在同一个合作场景下需保持唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 报告价格。单位人民币元
        /// </summary>
        [XmlElement("report_amount")]
        public string ReportAmount { get; set; }

        /// <summary>
        /// 报告场景码，不同合作方场景码不同。找对接的产品负责人获取相应场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
