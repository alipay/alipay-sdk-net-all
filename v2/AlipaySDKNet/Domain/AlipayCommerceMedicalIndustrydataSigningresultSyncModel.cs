using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataSigningresultSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataSigningresultSyncModel : AopObject
    {
        /// <summary>
        /// 合作医院code，由支付宝侧分配
        /// </summary>
        [XmlElement("hospital_code")]
        public string HospitalCode { get; set; }

        /// <summary>
        /// 签约合同ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [XmlElement("rejection_reason")]
        public string RejectionReason { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 状态 EFFECTIVE：已生效 REJECTED：已驳回
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
