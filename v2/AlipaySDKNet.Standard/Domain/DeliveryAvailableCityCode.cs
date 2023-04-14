using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryAvailableCityCode Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryAvailableCityCode : AopObject
    {
        /// <summary>
        /// 是否全国。 与city_codes二选一。只允许填true，否则不填。
        /// </summary>
        [XmlElement("all_city")]
        public bool AllCity { get; set; }

        /// <summary>
        /// 城市编码。与all_city二选一。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        [XmlArray("city_codes")]
        [XmlArrayItem("string")]
        public List<string> CityCodes { get; set; }
    }
}
