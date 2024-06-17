using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockCustomerDeliverydetailQueryResponse.
    /// </summary>
    public class AntfortuneStockCustomerDeliverydetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 签约协议号（uid在某个机构处的唯一标识）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 用户投放展位内容数组
        /// </summary>
        [XmlElement("delivery_detail_position")]
        public DeliveryDetailPositionVO DeliveryDetailPosition { get; set; }
    }
}
