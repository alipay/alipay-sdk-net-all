using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UseDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UseDetail : AopObject
    {
        /// <summary>
        /// 实付金额，单位是分
        /// </summary>
        [XmlElement("actual_amount")]
        public long ActualAmount { get; set; }

        /// <summary>
        /// 应付金额，单位是分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 权益使用的时间,格式yyyy-MM-dd HH:mm:ss (订单支付时间)
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 使用的权益关联的商品信息
        /// </summary>
        [XmlElement("goods_info")]
        public BenifitGoodsInfo GoodsInfo { get; set; }
    }
}
