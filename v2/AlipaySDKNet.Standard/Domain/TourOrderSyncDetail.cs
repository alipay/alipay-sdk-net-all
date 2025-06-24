using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TourOrderSyncDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TourOrderSyncDetail : AopObject
    {
        /// <summary>
        /// 票张数
        /// </summary>
        [XmlElement("biz_source_num")]
        public string BizSourceNum { get; set; }

        /// <summary>
        /// 用户身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        [XmlElement("order_info")]
        public string OrderInfo { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 项目id/景区id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("tele_no")]
        public string TeleNo { get; set; }
    }
}
