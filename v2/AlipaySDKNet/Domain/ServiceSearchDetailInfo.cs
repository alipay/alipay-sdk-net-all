using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceSearchDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceSearchDetailInfo : AopObject
    {
        /// <summary>
        /// 城市code
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 由机构在政务AI开放平台上传服务时定义服务id
        /// </summary>
        [XmlElement("out_data_id")]
        public string OutDataId { get; set; }

        /// <summary>
        /// 搜索到的服务相关性分数，分数越大相关性越高。
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
