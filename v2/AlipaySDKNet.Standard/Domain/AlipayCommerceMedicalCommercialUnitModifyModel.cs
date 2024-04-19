using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialUnitModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCommercialUnitModifyModel : AopObject
    {
        /// <summary>
        /// 修改门店操作类型
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 门店支持的商品ID列表
        /// </summary>
        [XmlArray("out_product_id_list")]
        [XmlArrayItem("string")]
        public List<string> OutProductIdList { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("unit_address")]
        public string UnitAddress { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("unit_city_code")]
        public string UnitCityCode { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("unit_contact_number")]
        public string UnitContactNumber { get; set; }

        /// <summary>
        /// 门店位置维度
        /// </summary>
        [XmlElement("unit_latitude")]
        public string UnitLatitude { get; set; }

        /// <summary>
        /// 门店位置经度
        /// </summary>
        [XmlElement("unit_longitude")]
        public string UnitLongitude { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("unit_name")]
        public string UnitName { get; set; }

        /// <summary>
        /// 门店营业时间
        /// </summary>
        [XmlElement("unit_opening_hours")]
        public string UnitOpeningHours { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [XmlElement("unit_out_code")]
        public string UnitOutCode { get; set; }

        /// <summary>
        /// 门店所属的商户PID
        /// </summary>
        [XmlElement("unit_out_pid")]
        public string UnitOutPid { get; set; }

        /// <summary>
        /// 门店状态
        /// </summary>
        [XmlElement("unit_status")]
        public string UnitStatus { get; set; }
    }
}
