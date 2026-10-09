using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemExchangeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemExchangeInfo : AopObject
    {
        /// <summary>
        /// 交兑换订单时作为外部订单号,用于防重复提交
        /// </summary>
        [XmlElement("exchange_token")]
        public string ExchangeToken { get; set; }

        /// <summary>
        /// 奖品code,唯一标识
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 奖品图片
        /// </summary>
        [XmlElement("item_logo")]
        public string ItemLogo { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 积分数
        /// </summary>
        [XmlElement("point_amount")]
        public long PointAmount { get; set; }

        /// <summary>
        /// 积分兑换提示
        /// </summary>
        [XmlElement("point_exchange_note")]
        public string PointExchangeNote { get; set; }

        /// <summary>
        /// 积分单位
        /// </summary>
        [XmlElement("point_unit")]
        public string PointUnit { get; set; }
    }
}
