using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOpenLogisticsDigestDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsOpenLogisticsDigestDTO : AopObject
    {
        /// <summary>
        /// 物流商名称
        /// </summary>
        [XmlElement("logistics_company_name")]
        public string LogisticsCompanyName { get; set; }

        /// <summary>
        /// 物流商快递单号
        /// </summary>
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 物流状态:0:已下单;1:已揽收;5:入库;2:已签收;8:已投柜;9:待取件;
        /// </summary>
        [XmlElement("logistics_status")]
        public long LogisticsStatus { get; set; }
    }
}
