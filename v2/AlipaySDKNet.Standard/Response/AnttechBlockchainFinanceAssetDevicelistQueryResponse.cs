using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetDevicelistQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceAssetDevicelistQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询的设备信息列表，为空表示未查询到结果。
        /// </summary>
        [XmlArray("device_list")]
        [XmlArrayItem("asset_device_relation")]
        public List<AssetDeviceRelation> DeviceList { get; set; }
    }
}
