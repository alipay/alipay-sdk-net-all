using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfinspectionSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfinspectionSyncModel : AopObject
    {
        /// <summary>
        /// 双方定义
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 履约方定义
        /// </summary>
        [XmlElement("order_code")]
        public string OrderCode { get; set; }

        /// <summary>
        /// 订单总金额，单位：元
        /// </summary>
        [XmlElement("order_price")]
        public string OrderPrice { get; set; }

        /// <summary>
        /// 履约方的支付状态
        /// </summary>
        [XmlElement("pay_status")]
        public long PayStatus { get; set; }

        /// <summary>
        /// 履约方定义
        /// </summary>
        [XmlElement("reserve_code")]
        public string ReserveCode { get; set; }

        /// <summary>
        /// 履约方的预约状态
        /// </summary>
        [XmlElement("reserve_status")]
        public long ReserveStatus { get; set; }

        /// <summary>
        /// 用户预约的检验检查时间
        /// </summary>
        [XmlElement("reserve_time")]
        public string ReserveTime { get; set; }

        /// <summary>
        /// 好大夫侧的单号
        /// </summary>
        [XmlElement("union_order_code")]
        public string UnionOrderCode { get; set; }
    }
}
