using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceEnergyRealtimedataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceEnergyRealtimedataSyncModel : AopObject
    {
        /// <summary>
        /// 设备上报信息字符串
        /// </summary>
        [XmlElement("data_list")]
        public string DataList { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

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
