using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetDevicelistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceAssetDevicelistQueryModel : AopObject
    {
        /// <summary>
        /// 资产所有人标示
        /// </summary>
        [XmlElement("asset_owner")]
        public string AssetOwner { get; set; }

        /// <summary>
        /// 需要查询的设备ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备物料类型，当设备ID重复时，可通过该字段区分。 具体取值可以参考金融资产上链文档。
        /// </summary>
        [XmlElement("device_supply_type")]
        public string DeviceSupplyType { get; set; }
    }
}
