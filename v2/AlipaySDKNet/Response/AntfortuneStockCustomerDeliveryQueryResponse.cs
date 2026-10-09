using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockCustomerDeliveryQueryResponse.
    /// </summary>
    public class AntfortuneStockCustomerDeliveryQueryResponse : AopResponse
    {
        /// <summary>
        /// 签约协议号（uid在某个机构处的唯一标识）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 用户投放展位内容
        /// </summary>
        [XmlArray("delivery_position")]
        [XmlArrayItem("delivery_position_v_o")]
        public List<DeliveryPositionVO> DeliveryPosition { get; set; }
    }
}
