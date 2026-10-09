using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceRecordFile Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceRecordFile : AopObject
    {
        /// <summary>
        /// 1.直联商户三绑定必传： RECORDS_TYPE_PID(直连pid)、 RECORDS_TYPE_SHOPID(shopid); 2.间联商户三绑定必传： RECORDS_TYPE_SMID（间连smid）、 RECORDS_TYPE_PID(直连pid)、 RECORDS_TYPE_SHOPID(shopid); 3.可用绑定升级三绑定必传： RECORDS_TYPE_SMID（间连smid）、 RECORDS_TYPE_PID(直连pid)、 RECORDS_TYPE_SHOPID(shopid); 4.可用绑定必传： RECORDS_TYPE_SMID（间连smid） RECORDS_TYPE_PID(pid)
        /// </summary>
        [XmlElement("records_type")]
        public string RecordsType { get; set; }

        /// <summary>
        /// 与records_type对应的参数值。 如直连商户pid：2088101156429885
        /// </summary>
        [XmlElement("records_value")]
        public string RecordsValue { get; set; }
    }
}
