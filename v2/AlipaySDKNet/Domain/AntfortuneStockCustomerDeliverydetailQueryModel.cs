using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockCustomerDeliverydetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockCustomerDeliverydetailQueryModel : AopObject
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

        /// <summary>
        /// 展位相关的特征参数，如展位关联的通知类型、机构信息等。使用时根据position_code列表内的展位code获取对应展位的特征参数
        /// </summary>
        [XmlElement("position_feature")]
        public string PositionFeature { get; set; }
    }
}
