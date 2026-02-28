using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceTpadirectpaystatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceTpadirectpaystatusSyncModel : AopObject
    {
        /// <summary>
        /// 直付码值
        /// </summary>
        [XmlElement("code_data")]
        public string CodeData { get; set; }

        /// <summary>
        /// 回传事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 业务需要拓展字段
        /// </summary>
        [XmlElement("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 个单号
        /// </summary>
        [XmlElement("individual_policy_no")]
        public string IndividualPolicyNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("medicine_list")]
        [XmlArrayItem("insurance_medicine_info")]
        public List<InsuranceMedicineInfo> MedicineList { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单总金额(单位：元，保留2位小数，退款为负数）
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 门店参数
        /// </summary>
        [XmlElement("outlet_info")]
        public OutletInfo OutletInfo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 退款金额(单位：元，保留2位小数，退款为负数）
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// TPA编号
        /// </summary>
        [XmlElement("tpa_id")]
        public string TpaId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
