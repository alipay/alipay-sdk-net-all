using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderDvcattrLocateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderDvcattrLocateQueryModel : AopObject
    {
        /// <summary>
        /// 设备点位蓝牙mac地址列表，如果不填则分页查询全量数据
        /// </summary>
        [XmlArray("bluetooth_mac")]
        [XmlArrayItem("string")]
        public List<string> BluetoothMac { get; set; }

        /// <summary>
        /// 分页的页数，表示第几页，从1开始
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 分页大小，根据处理情况，选择合适的分页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
