using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcomLogisticsOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EcomLogisticsOrderDTO : AopObject
    {
        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 发货时间
        /// </summary>
        [XmlElement("consign_time")]
        public string ConsignTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 真实物流单号
        /// </summary>
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 物流订单id
        /// </summary>
        [XmlElement("logistics_order_id")]
        public string LogisticsOrderId { get; set; }

        /// <summary>
        /// 物流状态
        /// </summary>
        [XmlElement("logistics_status")]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// 物流费用
        /// </summary>
        [XmlElement("post_fee")]
        public long PostFee { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        [XmlElement("recipient_address")]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// 收货地区
        /// </summary>
        [XmlElement("recipient_area")]
        public string RecipientArea { get; set; }

        /// <summary>
        /// 收货地区编码（国标）
        /// </summary>
        [XmlElement("recipient_area_code")]
        public string RecipientAreaCode { get; set; }

        /// <summary>
        /// 收货城市
        /// </summary>
        [XmlElement("recipient_city")]
        public string RecipientCity { get; set; }

        /// <summary>
        /// 收货人全名
        /// </summary>
        [XmlElement("recipient_full_name")]
        public string RecipientFullName { get; set; }

        /// <summary>
        /// 收货人移动电话
        /// </summary>
        [XmlElement("recipient_mobile_phone")]
        public string RecipientMobilePhone { get; set; }

        /// <summary>
        /// 收货人固定电话
        /// </summary>
        [XmlElement("recipient_phone")]
        public string RecipientPhone { get; set; }

        /// <summary>
        /// 收货省份
        /// </summary>
        [XmlElement("recipient_prov")]
        public string RecipientProv { get; set; }

        /// <summary>
        /// 收货镇、街道
        /// </summary>
        [XmlElement("recipient_town")]
        public string RecipientTown { get; set; }

        /// <summary>
        /// 是否拒签
        /// </summary>
        [XmlElement("refusal")]
        public bool Refusal { get; set; }

        /// <summary>
        /// 发货地址
        /// </summary>
        [XmlElement("sender_address")]
        public string SenderAddress { get; set; }

        /// <summary>
        /// 发货地区
        /// </summary>
        [XmlElement("sender_area")]
        public string SenderArea { get; set; }

        /// <summary>
        /// 发货地区编码（国标）
        /// </summary>
        [XmlElement("sender_area_code")]
        public string SenderAreaCode { get; set; }

        /// <summary>
        /// 发货城市
        /// </summary>
        [XmlElement("sender_city")]
        public string SenderCity { get; set; }

        /// <summary>
        /// 发货人全名
        /// </summary>
        [XmlElement("sender_full_name")]
        public string SenderFullName { get; set; }

        /// <summary>
        /// 发货人移动电话
        /// </summary>
        [XmlElement("sender_mobile_phone")]
        public string SenderMobilePhone { get; set; }

        /// <summary>
        /// 发货人固定电话
        /// </summary>
        [XmlElement("sender_phone")]
        public string SenderPhone { get; set; }

        /// <summary>
        /// 发货省份
        /// </summary>
        [XmlElement("sender_prov")]
        public string SenderProv { get; set; }

        /// <summary>
        /// 发货镇、街道
        /// </summary>
        [XmlElement("sender_town")]
        public string SenderTown { get; set; }
    }
}
