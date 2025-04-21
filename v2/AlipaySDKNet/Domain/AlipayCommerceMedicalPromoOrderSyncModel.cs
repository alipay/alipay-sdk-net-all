using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalPromoOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalPromoOrderSyncModel : AopObject
    {
        /// <summary>
        /// LM配置商品价格时填的客户业务值（权益id），医疗用来区分代币种类
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// biz_no
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 订单，“分”为单位。20，代表0.2元
        /// </summary>
        [XmlElement("cost_num")]
        public long CostNum { get; set; }

        /// <summary>
        /// 详细标识
        /// </summary>
        [XmlElement("detail_flag")]
        public long DetailFlag { get; set; }

        /// <summary>
        /// 订单创建的时候才有值，列表长度为1
        /// </summary>
        [XmlElement("item_list")]
        public string ItemList { get; set; }

        /// <summary>
        /// lm订单id
        /// </summary>
        [XmlElement("lm_order_id")]
        public string LmOrderId { get; set; }

        /// <summary>
        /// 主标识
        /// </summary>
        [XmlElement("main_flag")]
        public long MainFlag { get; set; }

        /// <summary>
        /// 主lm订单id
        /// </summary>
        [XmlElement("main_lm_order_id")]
        public string MainLmOrderId { get; set; }

        /// <summary>
        /// 医疗商品id
        /// </summary>
        [XmlElement("med_benefit_id")]
        public string MedBenefitId { get; set; }

        /// <summary>
        /// 变更时间
        /// </summary>
        [XmlElement("modified_time")]
        public long ModifiedTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 变化后的订单状态
        /// </summary>
        [XmlElement("order_status")]
        public long OrderStatus { get; set; }

        /// <summary>
        /// 积分数量
        /// </summary>
        [XmlElement("point_amount")]
        public long PointAmount { get; set; }

        /// <summary>
        /// 变更前订单状态
        /// </summary>
        [XmlElement("pre_order_status")]
        public long PreOrderStatus { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 淘宝订单id
        /// </summary>
        [XmlElement("tb_order_id")]
        public string TbOrderId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
