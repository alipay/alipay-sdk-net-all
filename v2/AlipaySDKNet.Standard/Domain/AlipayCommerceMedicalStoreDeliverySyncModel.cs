using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalStoreDeliverySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalStoreDeliverySyncModel : AopObject
    {
        /// <summary>
        /// 配送范围集合，仅支持高德坐标系的经纬度集。坐标数上限：60；电子围栏首尾坐标需闭合。
        /// </summary>
        [XmlArray("delivery_area_list")]
        [XmlArrayItem("delivery_point_d_t_o")]
        public List<DeliveryPointDTO> DeliveryAreaList { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
