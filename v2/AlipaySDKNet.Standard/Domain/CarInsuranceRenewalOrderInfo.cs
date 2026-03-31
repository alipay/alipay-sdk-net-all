using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarInsuranceRenewalOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarInsuranceRenewalOrderInfo : AopObject
    {
        /// <summary>
        /// 发动机号
        /// </summary>
        [XmlElement("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 保司名称
        /// </summary>
        [XmlElement("insurance_company_name")]
        public string InsuranceCompanyName { get; set; }

        /// <summary>
        /// 订单金额（单位：元，精确到分）
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 保险单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 推广门店ID
        /// </summary>
        [XmlElement("promotion_store_id")]
        public string PromotionStoreId { get; set; }

        /// <summary>
        /// 推广门店名称
        /// </summary>
        [XmlElement("promotion_store_name")]
        public string PromotionStoreName { get; set; }

        /// <summary>
        /// 车辆注册日期（YYYY-MM-DD格式）
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 统一社会信用代码（Unified Social Credit Code）
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }

        /// <summary>
        /// 车辆使用性质
        /// </summary>
        [XmlElement("use_type")]
        public string UseType { get; set; }

        /// <summary>
        /// 车型名称
        /// </summary>
        [XmlElement("veh_model_name")]
        public string VehModelName { get; set; }

        /// <summary>
        /// 车主身份证号
        /// </summary>
        [XmlElement("veh_owner_id_card_no")]
        public string VehOwnerIdCardNo { get; set; }

        /// <summary>
        /// 车主姓名
        /// </summary>
        [XmlElement("veh_owner_name")]
        public string VehOwnerName { get; set; }

        /// <summary>
        /// 车主手机号
        /// </summary>
        [XmlElement("veh_owner_phone")]
        public string VehOwnerPhone { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("vi_number")]
        public string ViNumber { get; set; }

        /// <summary>
        /// 车架号（VIN码）
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
