using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenPayResultModule Data Structure.
    /// </summary>
    [Serializable]
    public class OpenPayResultModule : AopObject
    {
        /// <summary>
        /// 支付结果主题内容
        /// </summary>
        [XmlElement("open_module_data")]
        public OpenModuleData OpenModuleData { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
