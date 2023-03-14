using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessParamsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessParamsDTO : AopObject
    {
        /// <summary>
        /// 实际订单时间，在乘车码场景，传入的是用户刷码乘车时间
        /// </summary>
        [XmlElement("actual_order_time")]
        public string ActualOrderTime { get; set; }

        /// <summary>
        /// 校园卡编号
        /// </summary>
        [XmlElement("campus_card")]
        public string CampusCard { get; set; }

        /// <summary>
        /// 虚拟卡卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 因公付金额
        /// </summary>
        [XmlElement("enterprise_pay_amount")]
        public string EnterprisePayAmount { get; set; }

        /// <summary>
        /// 因公付业务信息
        /// </summary>
        [XmlElement("enterprise_pay_info")]
        public string EnterprisePayInfo { get; set; }

        /// <summary>
        /// 商户传入的交易税费。需要落地风控使用
        /// </summary>
        [XmlElement("good_taxes")]
        public string GoodTaxes { get; set; }
    }
}
