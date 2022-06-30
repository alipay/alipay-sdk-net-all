using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaOpenAppRisktagQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaOpenAppRisktagQueryModel : AopObject
    {
        /// <summary>
        /// 数据类型，风报标识，例 行政处罚，裁判文书
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 模型标识，接口提供方提供
        /// </summary>
        [XmlElement("model")]
        public string Model { get; set; }

        /// <summary>
        /// 预测样本数据
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }
    }
}
