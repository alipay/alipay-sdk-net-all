using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOuterorderStatusNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOuterorderStatusNotifyModel : AopObject
    {
        /// <summary>
        /// 咨询场景
        /// </summary>
        [XmlElement("consult_business")]
        public string ConsultBusiness { get; set; }

        /// <summary>
        /// 小结链接
        /// </summary>
        [XmlElement("consult_summary_url")]
        public string ConsultSummaryUrl { get; set; }

        /// <summary>
        /// 咨询时间
        /// </summary>
        [XmlElement("consult_time")]
        public string ConsultTime { get; set; }

        /// <summary>
        /// 医生头像图片的网络地址（URL）用于展示医生形象。
        /// </summary>
        [XmlElement("doctor_avatar_url")]
        public string DoctorAvatarUrl { get; set; }

        /// <summary>
        /// 提供服务的医生姓名
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 职称
        /// </summary>
        [XmlElement("doctor_title")]
        public string DoctorTitle { get; set; }

        /// <summary>
        /// 履约单id
        /// </summary>
        [XmlElement("fulfillment_order_id")]
        public string FulfillmentOrderId { get; set; }

        /// <summary>
        /// 主单的状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("partner_order_id")]
        public string PartnerOrderId { get; set; }

        /// <summary>
        /// 处方链接
        /// </summary>
        [XmlElement("prescription_url")]
        public string PrescriptionUrl { get; set; }

        /// <summary>
        /// 订单金额：单位元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
