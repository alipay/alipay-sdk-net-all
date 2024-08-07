using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChargeSystemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ChargeSystemInfo : AopObject
    {
        /// <summary>
        /// 交流充电桩数量
        /// </summary>
        [XmlElement("ac_pile_num")]
        public long AcPileNum { get; set; }

        /// <summary>
        /// 直流充电桩数量
        /// </summary>
        [XmlElement("dc_pile_num")]
        public long DcPileNum { get; set; }

        /// <summary>
        /// 电表列表
        /// </summary>
        [XmlArray("electric_meter_no")]
        [XmlArrayItem("string")]
        public List<string> ElectricMeterNo { get; set; }

        /// <summary>
        /// 是否有序充电
        /// </summary>
        [XmlElement("orderable")]
        public bool Orderable { get; set; }

        /// <summary>
        /// 车位数量，默认0
        /// </summary>
        [XmlElement("park_num")]
        public long ParkNum { get; set; }

        /// <summary>
        /// 充电系统种类
        /// </summary>
        [XmlElement("system_category")]
        public string SystemCategory { get; set; }

        /// <summary>
        /// 总额定功率, 单位kw
        /// </summary>
        [XmlElement("total_rated_power")]
        public string TotalRatedPower { get; set; }

        /// <summary>
        /// 充电用途分类
        /// </summary>
        [XmlElement("use_type")]
        public string UseType { get; set; }

        /// <summary>
        /// 电压等级
        /// </summary>
        [XmlElement("voltag_level")]
        public string VoltagLevel { get; set; }
    }
}
