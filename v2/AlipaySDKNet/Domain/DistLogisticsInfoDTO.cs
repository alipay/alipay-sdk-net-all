using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DistLogisticsInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DistLogisticsInfoDTO : AopObject
    {
        /// <summary>
        /// 快递公司名称
        /// </summary>
        [XmlElement("express_comp_name")]
        public string ExpressCompName { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("express_no")]
        public string ExpressNo { get; set; }
    }
}
