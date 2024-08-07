using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAnttechAppcoreUserbizinfoQueryResponse.
    /// </summary>
    public class DatadigitalAnttechAppcoreUserbizinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户的供热信息，温度单位为摄氏度
        /// </summary>
        [XmlElement("heat_data")]
        public string HeatData { get; set; }

        /// <summary>
        /// 用户供热卡信息，数据为热力公司的数据
        /// </summary>
        [XmlElement("heat_list")]
        public string HeatList { get; set; }
    }
}
