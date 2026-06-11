using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHyInquiryorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHyInquiryorderSyncModel : AopObject
    {
        /// <summary>
        /// 域内问诊订单唯一标识，用户告诉域内操作的是哪一笔订单
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 医生端系统内部变更状态的时间
        /// </summary>
        [XmlElement("order_modify_time")]
        public string OrderModifyTime { get; set; }

        /// <summary>
        /// 外部isv侧医生的ID，注意要和医生基础数据同步的ID保持一致
        /// </summary>
        [XmlElement("out_doctor_id")]
        public string OutDoctorId { get; set; }

        /// <summary>
        /// 问诊平台编码，由支付宝侧统一分配
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 医生端操作订单状态发生变更后，对应状态映射此字段同步到域内
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 补充说明状态变更原因
        /// </summary>
        [XmlElement("status_change_desc")]
        public string StatusChangeDesc { get; set; }

        /// <summary>
        /// 当问诊订单状态是取消时，用户标识具体的取消类型
        /// </summary>
        [XmlElement("sub_status")]
        public string SubStatus { get; set; }
    }
}
