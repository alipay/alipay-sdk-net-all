using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SmartAddressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SmartAddressInfo : AopObject
    {
        /// <summary>
        /// 行政区代码-区，使用蚂蚁标准行政区划代码，可参考 http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/2020/index.html 注意：【区】 代码请使用由左开始的 6 位数字。
        /// </summary>
        [XmlElement("area_code")]
        public long AreaCode { get; set; }

        /// <summary>
        /// 行政区代码-市，使用蚂蚁标准行政区划代码，可参考 http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/2020/index.html 注意：【市】 代码请使用由左开始的 6 位数字。
        /// </summary>
        [XmlElement("city_code")]
        public long CityCode { get; set; }

        /// <summary>
        /// 自助售货机地址
        /// </summary>
        [XmlElement("machine_address")]
        public string MachineAddress { get; set; }

        /// <summary>
        /// 行政区代码-省，使用蚂蚁标准行政区划代码，可参考 http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/2020/index.html 注意：【省】 代码请使用由左开始的 6 位数字。
        /// </summary>
        [XmlElement("province_code")]
        public long ProvinceCode { get; set; }
    }
}
