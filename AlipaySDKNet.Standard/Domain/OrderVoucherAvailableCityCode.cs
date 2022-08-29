using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderVoucherAvailableCityCode Data Structure.
    /// </summary>
    [Serializable]
    public class OrderVoucherAvailableCityCode : AopObject
    {
        /// <summary>
        /// 是否全国。选择全国后，无须填写city_codes字段。系统默认填充全国全部城市信息。
        /// </summary>
        [XmlElement("all_city")]
        public bool AllCity { get; set; }

        /// <summary>
        /// 城市编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        [XmlArray("city_codes")]
        [XmlArrayItem("string")]
        public List<string> CityCodes { get; set; }
    }
}
