using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockCustomerDeliveryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockCustomerDeliveryQueryModel : AopObject
    {
        /// <summary>
        /// 签约协议号（uid在某个机构处的唯一标识）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 待查询展位码列表、支持批量查询
        /// </summary>
        [XmlArray("position_code")]
        [XmlArrayItem("string")]
        public List<string> PositionCode { get; set; }
    }
}
