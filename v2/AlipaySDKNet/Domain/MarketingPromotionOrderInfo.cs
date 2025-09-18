using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MarketingPromotionOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MarketingPromotionOrderInfo : AopObject
    {
        /// <summary>
        /// 预估金额（固定值）单位为元
        /// </summary>
        [XmlElement("assess_amount")]
        public string AssessAmount { get; set; }

        /// <summary>
        /// 预估最大金额（区间值）单位为元，与assess_amount互斥。当估价类型assess_type=RANGE_UNIT区间重量时，此时有最大金额（如衣物统收预估估价为区间2.5元-5元）。
        /// </summary>
        [XmlElement("assess_max_amount")]
        public string AssessMaxAmount { get; set; }

        /// <summary>
        /// 预估最大数量（区间值）单位为个、KG或G。与assess_quantity互斥。当估价类型assess_type=RANGE_UNIT区间重量时，此时有最大数量（如衣物统收预估重量为区间5KG-10KG）。
        /// </summary>
        [XmlElement("assess_max_quantity")]
        public string AssessMaxQuantity { get; set; }

        /// <summary>
        /// 预估最小金额（区间值）单位为元，与assess_amount互斥。当估价类型assess_type=RANGE_UNIT区间重量时，此时有最小金额（如衣物统收预估估价为区间2.5元-5元）。
        /// </summary>
        [XmlElement("assess_min_amount")]
        public string AssessMinAmount { get; set; }

        /// <summary>
        /// 预估最小数量（区间值）单位为个、KG或G，与assess_quantity互斥。当估价类型assess_type=RANGE_UNIT区间重量时，此时有最小数量（如衣物统收预估重量为区间5KG-10KG）。
        /// </summary>
        [XmlElement("assess_min_quantity")]
        public string AssessMinQuantity { get; set; }

        /// <summary>
        /// 预估数量（固定值）单位为个、KG或G，支持两位小数点。
        /// </summary>
        [XmlElement("assess_quantity")]
        public string AssessQuantity { get; set; }

        /// <summary>
        /// 回收商品估价类型
        /// </summary>
        [XmlElement("assess_type")]
        public string AssessType { get; set; }

        /// <summary>
        /// 一级推广员工ID
        /// </summary>
        [XmlElement("first_level_emp_id")]
        public string FirstLevelEmpId { get; set; }

        /// <summary>
        /// 订单质检总金额，单位为元
        /// </summary>
        [XmlElement("inspect_amount")]
        public string InspectAmount { get; set; }

        /// <summary>
        /// 单位为个、KG或G。若服务类目为CLOTHES_RECYCLE则单位为KG
        /// </summary>
        [XmlElement("inspect_quantity")]
        public string InspectQuantity { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("logistics_bill_no")]
        public string LogisticsBillNo { get; set; }

        /// <summary>
        /// 物流平台编码
        /// </summary>
        [XmlElement("logistics_platform")]
        public string LogisticsPlatform { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [XmlElement("order_modify_time")]
        public string OrderModifyTime { get; set; }

        /// <summary>
        /// 支付宝回收订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付宝回收订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("product_list")]
        [XmlArrayItem("marketing_product_info")]
        public List<MarketingProductInfo> ProductList { get; set; }

        /// <summary>
        /// 订单推广记录id
        /// </summary>
        [XmlElement("promo_id")]
        public string PromoId { get; set; }

        /// <summary>
        /// 二级推广员工ID
        /// </summary>
        [XmlElement("second_level_emp_id")]
        public string SecondLevelEmpId { get; set; }

        /// <summary>
        /// 回收服务类目code
        /// </summary>
        [XmlElement("service_category_code")]
        public string ServiceCategoryCode { get; set; }

        /// <summary>
        /// 推广活动报名id
        /// </summary>
        [XmlElement("signup_id")]
        public string SignupId { get; set; }

        /// <summary>
        /// 回收商品单位
        /// </summary>
        [XmlElement("unit_type")]
        public string UnitType { get; set; }
    }
}
