using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GreenCupsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GreenCupsDTO : AopObject
    {
        /// <summary>
        /// 环保二级类目；字典值:  自带杯:zidaibei; 马克杯:makebei; 直饮杯:zhiyinbei;
        /// </summary>
        [XmlElement("cup_type")]
        public string CupType { get; set; }

        /// <summary>
        /// 杯数; 本次购买的环保杯数量; 只有环保杯类型时,该字段必填;
        /// </summary>
        [XmlElement("cups_amount")]
        public string CupsAmount { get; set; }
    }
}
