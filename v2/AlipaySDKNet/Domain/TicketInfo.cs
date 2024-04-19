using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TicketInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TicketInfo : AopObject
    {
        /// <summary>
        /// 店铺地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 凭证预约类型，一般不需要传入。可选值为INSTANT/RESERVATION，其中INSTANT代表是实时凭证，RESERVATION代表是预约凭证，不传入默认为实时凭证。区别在于预约凭证一般不是当场可取，而是用户下单后的很多天之后才可以凭借凭证提取
        /// </summary>
        [XmlElement("resv_type")]
        public string ResvType { get; set; }

        /// <summary>
        /// 凭证可核销门店/货品自提门店，如果自提门店与购买门店不一致，可传入该字段提示用户自提门店
        /// </summary>
        [XmlElement("shop")]
        public string Shop { get; set; }

        /// <summary>
        /// 单据号 不同类型下单据号含义不同。若类型为MEAL_NUM，则ticket_no表示取餐号；若类型为PICKUP_CODE，则ticket_no表示取件码；其他类型查看小程序订单产品文档
        /// </summary>
        [XmlElement("ticket_no")]
        public string TicketNo { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// 凭证类型 具体类型查看产品文档
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
