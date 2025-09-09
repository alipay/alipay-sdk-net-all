using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceEnergyDeviceSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceEnergyDeviceSyncModel : AopObject
    {
        /// <summary>
        /// 交流充电桩实时数据数据列表。 列表长度最大100 当前字段已废弃(目前无使用，直接删除)
        /// </summary>
        [XmlArray("acc_pile_data_list")]
        [XmlArrayItem("ac_charge_pile_run_time_data")]
        public List<AcChargePileRunTimeData> AccPileDataList { get; set; }

        /// <summary>
        /// 充电设备类型 当前字段已废弃(合并至 data_type)
        /// </summary>
        [XmlElement("charge_device_type")]
        public string ChargeDeviceType { get; set; }

        /// <summary>
        /// 上报设备信息字符串
        /// </summary>
        [XmlElement("data_list")]
        public string DataList { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 直流充电桩实时数据列表。 列表长度最大100 当前字段已废弃(目前无使用，直接删除)
        /// </summary>
        [XmlArray("dcc_pile_data_list")]
        [XmlArrayItem("dc_charge_pile_run_time_data")]
        public List<DcChargePileRunTimeData> DccPileDataList { get; set; }

        /// <summary>
        /// 设备类型 当前字段已废弃(合并至 data_type)
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 产品合约码
        /// </summary>
        [XmlElement("product_agreement_code")]
        public string ProductAgreementCode { get; set; }

        /// <summary>
        /// 数据生成时标
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
