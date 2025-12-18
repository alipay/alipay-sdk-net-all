using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantNtooldataDayQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantNtooldataDayQueryModel : AopObject
    {
        /// <summary>
        /// 设备id，N7传sn，小蓝环和音箱传tagid
        /// </summary>
        [XmlArray("device_id_list")]
        [XmlArrayItem("string")]
        public List<string> DeviceIdList { get; set; }

        /// <summary>
        /// 查询设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 数据统计时间，具体到某年某月某天
        /// </summary>
        [XmlElement("metrics_date")]
        public string MetricsDate { get; set; }

        /// <summary>
        /// 第几页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 一页多少
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商户smid号
        /// </summary>
        [XmlArray("smid_list")]
        [XmlArrayItem("string")]
        public List<string> SmidList { get; set; }
    }
}
