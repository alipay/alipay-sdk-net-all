using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryInvoiceRefinedOilGasStation Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryInvoiceRefinedOilGasStation : AopObject
    {
        /// <summary>
        /// 加油卡发票号码列表
        /// </summary>
        [XmlArray("gas_card_invoice_no_list")]
        [XmlArrayItem("string")]
        public List<string> GasCardInvoiceNoList { get; set; }

        /// <summary>
        /// 开票环节
        /// </summary>
        [XmlElement("gas_card_invoice_stage")]
        public string GasCardInvoiceStage { get; set; }

        /// <summary>
        /// 加油站特定要素明细列表
        /// </summary>
        [XmlArray("gas_station_list")]
        [XmlArrayItem("industry_invoice_gas_station_info")]
        public List<IndustryInvoiceGasStationInfo> GasStationList { get; set; }
    }
}
