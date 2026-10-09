using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CropsSoilMoistureInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CropsSoilMoistureInfo : AopObject
    {
        /// <summary>
        /// 数据实际日期，YYYYMMDD
        /// </summary>
        [XmlElement("actual_date")]
        public string ActualDate { get; set; }

        /// <summary>
        /// 附加信息
        /// </summary>
        [XmlElement("addition_info")]
        public string AdditionInfo { get; set; }

        /// <summary>
        /// 作物编码
        /// </summary>
        [XmlElement("crop_code")]
        public string CropCode { get; set; }

        /// <summary>
        /// 预测日期，YYYYMMDD
        /// </summary>
        [XmlElement("forecast_date")]
        public string ForecastDate { get; set; }

        /// <summary>
        /// 风险监测指数，值域0～1
        /// </summary>
        [XmlElement("risk_index")]
        public string RiskIndex { get; set; }

        /// <summary>
        /// 风险等级，值域0～4，按严重程度递增
        /// </summary>
        [XmlElement("risk_level")]
        public long RiskLevel { get; set; }
    }
}
