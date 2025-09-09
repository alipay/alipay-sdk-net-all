using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehicleCheckDetailItem Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleCheckDetailItem : AopObject
    {
        /// <summary>
        /// 检测明细title
        /// </summary>
        [XmlElement("check_item_code")]
        public string CheckItemCode { get; set; }

        /// <summary>
        /// 检测明细结果
        /// </summary>
        [XmlElement("check_item_result")]
        public long CheckItemResult { get; set; }
    }
}
