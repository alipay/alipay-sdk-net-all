using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsPreOrdeNotifyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsPreOrdeNotifyDTO : AopObject
    {
        /// <summary>
        /// 预下单外部幂等key
        /// </summary>
        [XmlElement("out_employee_biz_no")]
        public string OutEmployeeBizNo { get; set; }

        /// <summary>
        /// 预下单ID
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }
    }
}
