using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceEnergyStationsystemSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceEnergyStationsystemSyncModel : AopObject
    {
        /// <summary>
        /// 设备数据列表
        /// </summary>
        [XmlElement("data_list")]
        public string DataList { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 产品合约码
        /// </summary>
        [XmlElement("product_agreement_code")]
        public string ProductAgreementCode { get; set; }

        /// <summary>
        /// 数据生成时间，时标。 格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("real_time")]
        public string RealTime { get; set; }

        /// <summary>
        /// 数据上报时间
        /// </summary>
        [XmlElement("report_time")]
        public string ReportTime { get; set; }
    }
}
