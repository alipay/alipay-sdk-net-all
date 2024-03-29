using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEdeductForecastQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEdeductForecastQueryModel : AopObject
    {
        /// <summary>
        /// 该扣款批次总金额
        /// </summary>
        [XmlElement("batch_order_amount")]
        public string BatchOrderAmount { get; set; }

        /// <summary>
        /// 当前批次的订单总数
        /// </summary>
        [XmlElement("batch_order_counts")]
        public long BatchOrderCounts { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 出账机构（如果填了就是到出账机构粒度，如果没填就是到销账机构粒度）
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 销账机构（缴费业务必填，其他业务选填）
        /// </summary>
        [XmlElement("chargeoff_inst")]
        public string ChargeoffInst { get; set; }

        /// <summary>
        /// 代扣扣款日期
        /// </summary>
        [XmlElement("deduct_date")]
        public string DeductDate { get; set; }

        /// <summary>
        /// 子业务类型
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
