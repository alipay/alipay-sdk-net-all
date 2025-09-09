using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceEnergyPredictSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceEnergyPredictSubmitModel : AopObject
    {
        /// <summary>
        /// 预测数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 负荷资源外部Id，如站点id、系统id、设备id等
        /// </summary>
        [XmlElement("out_resource_id")]
        public string OutResourceId { get; set; }

        /// <summary>
        /// 预测日期
        /// </summary>
        [XmlElement("predict_date")]
        public string PredictDate { get; set; }

        /// <summary>
        /// 预测时间段内的平均功率
        /// </summary>
        [XmlArray("predict_load_list")]
        [XmlArrayItem("load_info_node")]
        public List<LoadInfoNode> PredictLoadList { get; set; }

        /// <summary>
        /// 时间间隔，单位 分钟；
        /// </summary>
        [XmlElement("predict_timespan")]
        public long PredictTimespan { get; set; }

        /// <summary>
        /// 产品合约码
        /// </summary>
        [XmlElement("product_agreement_code")]
        public string ProductAgreementCode { get; set; }
    }
}
