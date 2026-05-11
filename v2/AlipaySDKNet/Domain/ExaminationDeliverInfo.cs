using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExaminationDeliverInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExaminationDeliverInfo : AopObject
    {
        /// <summary>
        /// 收货人详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 物料订单号
        /// </summary>
        [XmlElement("carrier_order_no")]
        public string CarrierOrderNo { get; set; }

        /// <summary>
        /// 收货人电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
