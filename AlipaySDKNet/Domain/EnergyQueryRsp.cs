using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnergyQueryRsp Data Structure.
    /// </summary>
    [Serializable]
    public class EnergyQueryRsp : AopObject
    {
        /// <summary>
        /// 失败描述信息
        /// </summary>
        [XmlElement("failed_msg")]
        public string FailedMsg { get; set; }

        /// <summary>
        /// 能量数量，单位g
        /// </summary>
        [XmlElement("full_energy")]
        public string FullEnergy { get; set; }

        /// <summary>
        /// 物品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// item列表
        /// </summary>
        [XmlElement("items")]
        public EnergyExtRequest Items { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
